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

		public MySql(string host, string us, string pwd, string bd, string puerto="3306"):base()
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
                { 
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
                    for (int i = 0; i < valores.Count; i++)
                    {
                        //concatenar un nombreDeCampo = valor (con sus '')
                        valsConcat +=  (valores[i].llevaApostrofes ? "'" + valores[i].valor + "'," : valores[i].valor + ",");
                    }
                    valsConcat = valsConcat.Remove(valsConcat.Length - 1);
                    //definir el query en el MysqlCommand
                    commando = new MySqlCommand($"INSERT INTO {tabla} ({camposConcat}) VALUES({valsConcat});");
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
                }
            catch (MySqlException mex)
            {
                //trono la conexion o el insert
                this.msgError = " ERROR AL CONECTARNOS A LA BASE DE DATOS " +mex.Message;
            }
            catch (Exception ex)
            {
                //trono la conexion o el insert
                this.msgError = " NO SE PUDO REGISTRAR UN NUEVO PRODUCTO, ERROR DE WINDWOS " + ex.Message;
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
                //Vemos si lleva apostrofe
                for (int i = 0; i < campos.Count; i++)
                {
                    //concatenar un nombreDeCampo = valor (con sus '')
                    camposConcat += campos[i] + "=" + (valores[i].llevaApostrofes ? "'" + valores[i].valor + "'," : valores[i].valor + ",");
                }
                camposConcat = camposConcat.Remove(camposConcat.Length - 1);//quitamos la ultima coma
                //damos la query
                commando = new MySqlCommand($"UPDATE {tabla} SET {camposConcat} WHERE id={id};");
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
                this.msgError = "ERROR, PROBLEMAS DE CONEXÍÓN " + mex.Message;

            } catch (Exception ex) {
                this.msgError = "ERROR AL MODIFICAR POR PROBLEMA DE WINDOWS" + ex.Message;
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
                //Definimos el comando. 
                commando = new MySqlCommand($"DELETE FROM {tabla} WHERE id={id};");
                //Relacionamos el comando con la conexión
                commando.Connection = con;
                int res = commando.ExecuteNonQuery();
                if (res == 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
            }
            catch (MySqlException mex)
            {
                this.msgError = "LA BASE DE DATOS NO PUDO ELIMINAR EL REGISTRO " + mex.Message;
            }
            catch (Exception ex)
            {
                this.msgError = "ERROR AL ELIMINAR PRODUCTO " + ex.Message;
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
                commando = new MySqlCommand($"SELECT * FROM {tabla};");
                commando.Connection = con;
                //ejecutar el query
                dr = commando.ExecuteReader();
                //validar el resultado del query, y preparar para devolver datos
                if (dr.HasRows)
                {
                    //leemos todos los registros en un while
                    while (dr.Read())
                    {   
                        //cada elemento es un arreglo de objects
                        object[] registro = new object[dr.FieldCount];
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            registro[i] = dr.GetValue(i);
                        }
                        //lo cargamos a la lista
                        resultado.Add(registro);
                    }
                }
                else {
                    this.msgError = $"NO SE ENCONTRARON REGISTROS EXISTENTES {tabla}.";
                    //que devolvemos??
                    resultado = new List<object[]>(); //"chetos", "bolsa de 45gr", 34.00, "234234234324"
                }
            }
            catch (MySqlException mex)
            {
                this.msgError = "ERROR AL REALIZAR CONSULTAR A LA BASE DE DATOS " + mex.Message;
            }
            catch (Exception ex){
               this.msgError = "ERROR DE WINDOWS" + ex.Message;
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
                commando = new MySqlCommand($"SELECT * FROM {tabla} WHERE {criterioBusqueda};");
                //ejecutar el query
                dr = commando.ExecuteReader();
                //validar el resultado del query, y preparar para devolver datos
                if (dr.HasRows)
                {
                    //leemos todos los registros en un while
                    while (dr.Read())
                    {
                        //cada elemento es un arreglo de objects
                        object[] registro = new object[dr.FieldCount];
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            registro[i] = dr.GetValue(i);
                        }
                        //lo cargamos a la lista
                        resultado.Add(registro);
                    }
                }
                else
                {
                    this.msgError = $"ERROR AL ENCONTAR REGISTRO {tabla}.";
                    //que devolvemos??
                    resultado = new List<object[]>(); //"chetos", "bolsa de 45gr", 34.00, "234234234324"
                }
            }
            catch (MySqlException mex)
            {
                this.msgError = "ERROR AL CONSULTAR LA BASE DE DATOS " + mex.Message;
            }
            catch (Exception ex)
            {
                this.msgError = "ERROR DE WINDWOS " + ex.Message;
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

