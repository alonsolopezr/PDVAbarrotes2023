
using System;
namespace Back_CRUDs_BD
{
	public class PruebaInstancia
	{
		public PruebaInstancia()
		{
			CRUDs_BD baseDatos;
			baseDatos = new MySql("localhost", "root", "123123", "pdvBD");

            baseDatos.insertar(
				"productos",
				new List<string>() { "id", "nombre", "precio" },
				new List<string>() { "2", "maruchar", "33.00" });
        }
    }
}

