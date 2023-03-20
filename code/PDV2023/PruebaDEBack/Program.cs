using System;
using Back_CRUDs_BD;

namespace PruebaDEBack  // Note: actual namespace depends on the project name.
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("probando la conexion a localhost, pdv, us root, pwd root, port=8889");
            CRUDs_BD baseDeDatos = new Back_CRUDs_BD.MySql("localhost", "root", "", "gamestore_pdv", "3306");
            List<object[]> res = baseDeDatos.consulta("productos");


        }
    }
}