using Back_CRUDs_BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middle_gamestore_PDV
{  
    public class Empleado
    {
        //Definimos las variables. 
        public string nombre;
        public string apellido;
        public string celular;
        public string password;
        public string email;
        public int idEmpleado; //la utilizaremos para la id del empleado. 
        public Roles rol;
        public string imagen;
        CRUDs_BD bd;
        public static string msgError;
        public Empleado() 
        {
            //crear una instancia de MYSQL a mi bd
            bd = new Back_CRUDs_BD.MySql("localhost", "root", "", "gamestore_pdv");//el puerto esta por default
        }
        //LLAMAMOS LOS MÉTODOS DEL CRUD. 
        public bool crear(string nom, string apellido, string celular, string password, string email, int idEmpleado, Roles rol, string imagen)
        {
            List<string> nombresCampos = new List<string>()
            {
                    "nombre", "apellido", "celular", "password", "email", "idEmpleado", "rol", "imagen"
            };

            List<ValoresAInsertar> vals = new List<ValoresAInsertar>();
            vals.Add(new ValoresAInsertar(nom));
            vals.Add(new ValoresAInsertar(apellido));
            vals.Add(new ValoresAInsertar(celular));
            vals.Add(new ValoresAInsertar(password));
            vals.Add(new ValoresAInsertar(email));
            vals.Add(new ValoresAInsertar(idEmpleado.ToString(), false));//al ser int no lleva '' en la query, por lo cual se la quitamos. 
            vals.Add(new ValoresAInsertar(rol.ToString()));
            vals.Add(new ValoresAInsertar(imagen));

            bool resultado = this.bd.insertar("usuarios", nombresCampos, vals);
            //valir el res
            if (resultado == false)
                Empleado.msgError = this.bd.msgError;

            return resultado;
        }
        public bool modificar(string nom, string apellido, string celular, string password, string email, int idEmpleado, Roles rol, string imagen, int id)
        {
            List<string> nombresCampos = new List<string>()
            {
                    "nombre", "apellido", "celular", "password", "email", "idEmpleado", "rol", "imagen"
            };

            List<ValoresAInsertar> vals = new List<ValoresAInsertar>();
            vals.Add(new ValoresAInsertar(nom));
            vals.Add(new ValoresAInsertar(apellido));
            vals.Add(new ValoresAInsertar(celular));
            vals.Add(new ValoresAInsertar(password));
            vals.Add(new ValoresAInsertar(email));
            vals.Add(new ValoresAInsertar(idEmpleado.ToString(), false));//al ser int no lleva '' en la query, por lo cual se la quitamos. 
            vals.Add(new ValoresAInsertar(rol.ToString()));
            vals.Add(new ValoresAInsertar(imagen));

            bool resultado = this.bd.insertar("usuarios", nombresCampos, vals);
            //valir el res
            if (resultado == false)
                Empleado.msgError = this.bd.msgError;

            return resultado;
        }
        //ELIMINAR
        public bool borrar(int id)
        {
            bool res = this.bd.borrar("usuarios", id);
            if (res = false)
                Empleado.msgError = this.bd.msgError;
            return res;
        }
        public List<object[]> consultarTodos() //DEVOLVEMOS TODOS LOS ASPECTOS. 
        {
            return this.bd.consulta("usuarios");
        }
        //consultar
        public double consultarEmpleado(int id)
        {
            List<object[]> res = this.bd.consulta("usuarios", "idEmpleado=" + id); //vamos a utilizar la id del empleado 
            int numEmpleado = 0;//Con esto guardaremos el numero del empleado para la consulta. 
            //VALIDAMOS QUE SOLO SEA UN ELEMENTO CON LA PROPIEDAD 'COUNT'
            if (res.Count == 1)
            {
                object[] tempo = res[0]; //PARA RECIBIR EL ARREGLO DEL ELEMENTO UNO
                numEmpleado = int.Parse(tempo[5].ToString());//ESTE ES PARA SACAR EL ELEMENTO QUE NECESITAMOS QUE ES EL PRECIO EN EL ESPACIO 5 que es el idEmpleado 
            }
            else
            {
                Empleado.msgError = this.bd.msgError;
                id = -1; //ESTE PARA QUE INDIQUE EL ERROR. POR SI TENEMOS UN PRECIO DE 0 Y NO HAYA UNA AMBIGUEDAD. 
            }

            return numEmpleado;
        }
    } 
}
