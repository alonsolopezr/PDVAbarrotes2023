using System;
using MySql.Data.MySqlClient;

namespace Back_CRUDs_BD
{
	public class MySql:CRUDs_BD
	{
        /// <summary>
        /// variables de conexion y acceso a BD
        /// </summary>
        MySqlConnection con;
        MySqlCommand commando;
        MySqlDataReader dr;

		public MySql(string host, string us, string pwd, string bd, string puerto="9764"):base()
		{
            //vamos a inicializar los valores de conexión en el connectionString
            this.connectionString = $"Server={host};Port={puerto};Database={bd};Uid={us};Pwd={pwd};";
            //creamos la conexion con el connnectioString
            con = new MySqlConnection(connectionString);

		}

        public override bool insertar(string tabla, List<string> campos, List<ValoresAInsertar> valores)
        {
            //definir var de resultado
            bool resultado = false;
            //programar el ESQUELETO de ejecutar una ACCION de QUERY en BD
            try
            {
                //abrir una conexion
                if(con.State == System.Data.ConnectionState.Closed)
                con.Open();
                //vamos a concatenar todos los CAMPOS en un solo string, separados por ,
                string camposConcat = "";
                foreach (var campo in campos)
                {
                    camposConcat += campo + ",";
                }
                //COMO QUITAR LA ULTIMA COMA??   XYZ = 3 (0,1,2)
                camposConcat = camposConcat.Remove(camposConcat.Length-1);
                string valsConcat="";
                //concatenamos los valores, y si llevan apostrofe
                foreach (ValoresAInsertar valor in valores)
                {

                    if (valor.llevaApostrofes) //????
                    {
                        valsConcat += "'" + valor + "',";
                    }
                    else
                    {
                        valsConcat += valor + ",";
                    }
                }
                valsConcat = valsConcat.Remove(valsConcat.Length - 1);
                //definir el query en el MysqlCommand
                commando = new MySqlCommand($"INSERT INTO {tabla} ({camposConcat}) VALUES({valsConcat})");
                //Relacionar el COMMAND con la CONEXION
                commando.Connection = con;
                //EJECUTAR EL QUERY
                int res = commando.ExecuteNonQuery();
                //Validar que se ejecuto correctamente
                if (res == 1)
                    resultado = true;
                else
                {
                    resultado = false;
                    this.msgError = "NO SE REGISTRÓ EL NUEVO RENGLÓN";
                }
                /// si no .... msgError
            }
            catch (MySqlException mex)
            {
                //trono la conexion o el insert
                this.msgError = "No se pudo insertar el nuevo registro, por que no se conectó a la BD. " +mex.Message;
            }
            catch (Exception ex)
            {
                //trono la conexion o el insert
                this.msgError = "No se pudo insertar el nuevo registro, por error general de windows. " + ex.Message;
            }
            finally
            {
                //cerrar la conexion
                if(con.State==System.Data.ConnectionState.Open)
                con.Close();
            }
            //regresamos si se insertó o no el registro nuevo
            return resultado;
        }

        public override bool modificar(string tabla, List<string> campos, List<ValoresAInsertar> valores, int id)
        {
            bool resultado = false;
            try
            {
                //abrir conexion
                if (con.State == System.Data.ConnectionState.Closed)
                    con.Open();
                string camposConcat = "";
                //definir COMMMAND
                for (int i = 0; i < campos.Count; i++)
                {
                    //concatenar un nombreDeCampo = valor (con sus '')
                    camposConcat += campos[i] + "=" + (valores[i].llevaApostrofes ? "'" + valores[i].valor + "'," : valores[i].valor + ",");
                    //if (valores[i].llevaApostrofes)
                    //    camposConcat += campos[i] + "=" + "'" + valores[i].valor + "',";
                    //else
                    //    camposConcat += campos[i] + "="  + valores[i].valor + ",";
                }
                camposConcat = camposConcat.Remove(camposConcat.Length - 1);
                
                commando = new MySqlCommand($"UPDATE {tabla} SET {camposConcat} WHERE id={id}");

                //UPDATE productos SET nombre='CHEETOS', precio=30.05, cod_barras='02323922882999392' WHERE id=90;

                //asociar la conexion al command
                commando.Connection = con;
                //ejecutar el command
                int res = commando.ExecuteNonQuery();
                //validar el command
                if (res == 1)
                    resultado = true;
                else
                    resultado = false;

            } catch (MySqlException mex) {
                this.msgError = "No se pudo moddificar el registro por problema de conexión. " + mex.Message;

            } catch (Exception ex) {
                this.msgError = "No se pudo modificar el registro por problema de windows. " + ex.Message;
            } finally {
                //cerramos conex
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
            //devolvemos el boool correspondiente
            return resultado;
        }


        public override bool borrar(string tabla, int id)
        {
            //DELETE FROM tabla WHERE id=90;
            bool resultado = false;
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                    con.Open();
                commando = new MySqlCommand($"DELETE FROM {tabla} WHERE id={id}");
                commando.Connection = con;
                int res = commando.ExecuteNonQuery();
                if (res == 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                    //msgError
                }
            }
            catch (MySqlException mex)
            {
                this.msgError = "NO se pudo borrar el registro, por error de BD. " + mex.Message;
            }
            catch (Exception ex)
            {
                this.msgError = "NO se pudo borrar el registro. " + ex.Message;
            }
            finally {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }

            //devolvemos si se boorró o nó
            return resultado;
            
        }

        public override List<object[]> consulta(string tabla)
        {
            List<object[]> resultado = new List<object[]>();
            //hacer el bloque try catch
            try
            {
                //validar conexion y abrirla
                if(con.State == System.Data.ConnectionState.Closed)
                    con.Open();
                //establecer el QUERY----> SELECT * FROM tabla
                commando = new MySqlCommand($"SELECT * FROM {tabla}");
                commando.Connection = con;
                //ejecutar el query
                dr = commando.ExecuteReader();
                //validar el resultado del query, y preparar para devolver datos
                if (dr.HasRows)
                {
                    //leemos todos los registros en un while
                    while (dr.Read())
                    {
                        //cuantos campos trae el registro??
                        
                        //cada elemento es un arreglo de objects
                        object[] registro = new object[dr.FieldCount];
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            registro[i] = dr.GetValue(i);
                        }
                        //lo cargamos a la lista
                        resultado.Add(registro);
                    }
                    //?? ya esta listo
                }
                else {
                    this.msgError = $"No existen registros en la tabla {tabla}.";
                    //que devolvemos??
                    resultado = new List<object[]>(); //"chetos", "bolsa de 45gr", 34.00, "234234234324"
                }
            }
            catch (MySqlException mex)
            {
                this.msgError = "No se pudo hacer la consulta en el servidor de BD. " + mex.Message;
            }
            catch (Exception ex){
               this.msgError = "No se pudo hacer la consulta por error de windows. " + ex.Message;
            }
            finally {
                if(con.State==System.Data.ConnectionState.Open)
                con.Close();
            }
            return resultado;
        }

        public override List<object[]> consulta(string tabla, string criterioBusqueda)
        {
            List<object[]> resultado = new List<object[]>();
            //hacer el bloque try catch
            try
            {
                //validar conexion y abrirla
                if (con.State == System.Data.ConnectionState.Closed)
                    con.Open();
                //establecer el QUERY----> SELECT * FROM tabla
                commando = new MySqlCommand($"SELECT * FROM {tabla} WHERE {criterioBusqueda}");
                //relacionar conexion a command
                commando.Connection = con;
                //ejecutar el query
                dr = commando.ExecuteReader();
                //validar el resultado del query, y preparar para devolver datos
                if (dr.HasRows)
                {
                    //leemos todos los registros en un while
                    while (dr.Read())
                    {
                        //cuantos campos trae el registro??

                        //cada elemento es un arreglo de objects
                        object[] registro = new object[dr.FieldCount];
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            registro[i] = dr.GetValue(i);
                        }
                        //lo cargamos a la lista
                        resultado.Add(registro);
                    }
                    //?? ya esta listo
                }
                else
                {
                    this.msgError = $"No existen registros en la tabla {tabla}.";
                    //que devolvemos??
                    resultado = new List<object[]>(); //"chetos", "bolsa de 45gr", 34.00, "234234234324"
                }
            }
            catch (MySqlException mex)
            {
                this.msgError = "No se pudo hacer la consulta en el servidor de BD. " + mex.Message;
            }
            catch (Exception ex)
            {
                this.msgError = "No se pudo hacer la consulta por error de windows. " + ex.Message;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
            return resultado;
        }
    }
}

