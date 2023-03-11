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

        public override bool insertar(string tabla, List<string> campos, List<string> valores)
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
                //concatenamos los valores
                foreach (var valor in valores)
                {
                    int valorInt = 0; //"0"
                    double valorDouble = 0;
                    int.TryParse(valor.ToString(),out valorInt);
                    double.TryParse(valor.ToString(),out valorDouble);
                    if (valorInt==valorDouble) //????
                        //como saber que valores son NUMERICOS y no ponerle ''??
                        valsConcat += "'" + valor + "',";
                    else if(valorInt != valorDouble)
                        valsConcat += valor + ",";
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
                this.msgError = "No se pudo insertar el nuevo registro, por que no se conectó a la BD. "+mex.Message;
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

        public override bool modificar(string tabla, List<string> campos, List<string> valores, int id)
        {
            throw new NotImplementedException();
        }


        public override bool borrar(string tabla, int id)
        {
            throw new NotImplementedException();
        }

        public override object consulta(string tabla)
        {
            throw new NotImplementedException();
        }

        public override object consulta(string tabla, string criterioBusqueda)
        {
            throw new NotImplementedException();
        }

       

      
    }
}

