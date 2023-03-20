using System;
using Back_CRUDs_BD;

namespace Middle_gamestore_PDV
{
	public class Producto
	{
		//propiedades de la clase
		public int id;
		public string nombre;
		public string descripcion;
		public double precio;
		public string cod_barras;
		public string imagen;
		public Consola unidad;

		CRUDs_BD bd;//CON ESTO REUTILIZAMOS EL CRUDS
		//var statis de  msg de error PARA PODERLA UTILIZAR EN TODAS LAS CAPAS. 
		public static string msgError;

		public Producto()
		{
			//crear una instancia de MYSQL a mi bd
			bd = new Back_CRUDs_BD.MySql("localhost", "root", "", "gamestore_pdv","3306");
		}

		//LLAMAMOS LOS MÉTODOS DEL CRUD. 
		public bool crear(string nom, string desc, double precio, string cod_barras, string imagen, Consola unidad)
		{
			List<string> nombresCampos = new List<string>()
			{
					"nombre", "descripcion", "precio", "cod_barra", "imagen", "unidad"
			};

			List<ValoresAInsertar> vals = new List<ValoresAInsertar>();
			vals.Add(new ValoresAInsertar(nom));
			vals.Add(new ValoresAInsertar(desc));
			vals.Add(new ValoresAInsertar(precio.ToString(), false));
			vals.Add(new ValoresAInsertar(cod_barras));
			vals.Add(new ValoresAInsertar(imagen));
			vals.Add(new ValoresAInsertar(unidad.ToString()));

            bool resultado =  this.bd.insertar("productos", nombresCampos, vals);
			//valir el res
			if (resultado == false)
				Producto.msgError = this.bd.msgError;

			return resultado;
		}
        public bool modificar(string nom, string desc, double precio, string cod_barras, string imagen, Consola unidad, int id)
        {
            List<string> nombresCampos = new List<string>()
            {
                    "nombre", "descripcion", "precio", "cod_barras", "imagen", "unidad"
            };

            List<ValoresAInsertar> vals = new List<ValoresAInsertar>();
            vals.Add(new ValoresAInsertar(nom));
            vals.Add(new ValoresAInsertar(desc));
            vals.Add(new ValoresAInsertar(precio.ToString(), false));//aquí cambiamos el valor iniciar por lo cual le quitamos los apostrofes desde el back. 
            vals.Add(new ValoresAInsertar(cod_barras));
            vals.Add(new ValoresAInsertar(imagen));
            vals.Add(new ValoresAInsertar(unidad.ToString()));

            bool resultado = this.bd.modificar("productos", nombresCampos, vals, id);
            //valir el res
            if (resultado == false)
                Producto.msgError = this.bd.msgError;

            return resultado;
        }

		//ELIMINAR
		public bool borrar(int id) 
		{
			bool res = this.bd.borrar("productos", id);
			if (res = false)
				Producto.msgError = this.bd.msgError;
			return res;
		}

		//consultar
		public List<object[]> consultarTodos() //DEVOLVEMOS TODOS LOS ASPECTOS. 
		{
			return this.bd.consulta("productos");
		}

		//CONSULTAR PRECIO POR EL ID DEL PRODUCTO. 
		/// <summary>
		/// 
		/// </summary>		
		/// <param name="id"></param>
		/// <returns> El precio del producto con id consultado, o -1 para indicar un error. </returns>
		public double consultarPrecio(int id) {
			List<object[]> res = this.bd.consulta("productos", "id=" + id); //GUARDAMOS LA VARIABLE EN UN ARREGLO PARA PODER UTILIZARLO Y QUE NOS DEVUELVA UN SOLO VALOR QUE ES EL PRECIO. 
			double precio = 0;
			//VALIDAMOS QUE SOLO SEA UN ELEMENTO CON LA PROPIEDAD 'COUNT'
			if (res.Count == 1)
			{
				object[] tempo = res[0]; //PARA RECIBIR EL ARREGLO DEL ELEMENTO UNO
				precio = double.Parse(tempo[3].ToString());//ESTE ES PARA SACAR EL ELEMENTO QUE NECESITAMOS QUE ES EL PRECIO EN EL ESPACIO 3 
			}
			else 
			{
				Producto.msgError = this.bd.msgError;
				precio = -1; //ESTE PARA QUE INDIQUE EL ERROR. POR SI TENEMOS UN PRECIO DE 0 Y NO HAYA UNA AMBIGUEDAD. 
			}

			return precio;
		}

        public Producto consultarPorCodBarras(string codBarras)
        {
			Producto prodResultado = new Producto();//es un producto nuevo

            List<object[]> res = this.bd.consulta("productos", "cod_barras=" + codBarras);
            //validamos que traig un elemento la lista
            if (res.Count == 1)
            {
				Consola presentacionTexto ;
                object[] tempo = res[0];
				prodResultado.id = int.Parse(tempo[0].ToString());
				prodResultado.nombre = tempo[1].ToString();
				prodResultado.descripcion = tempo[2].ToString();
                prodResultado.precio = double.Parse(tempo[3].ToString());
				prodResultado.cod_barras = tempo[4].ToString();
				prodResultado.imagen = tempo[5].ToString();

				switch (tempo[6].ToString())
				{
					case "XBOX":
						presentacionTexto = Consola.XBOX;
                        break;
					case "PLAYSTATION":
						presentacionTexto = Consola.PLAYSTATION;
                        break;
					case "WI":
						presentacionTexto = Consola.WI;
                        break;
					case "NINTENDO":
						presentacionTexto = Consola.NINTENDO;
                        break;
					case "PC":
						presentacionTexto = Consola.PC;
						break;
					default:
						presentacionTexto = Consola.XBOX;
						break;

				}
				prodResultado.unidad = presentacionTexto;
				//SI HAY OBJETO DEVOLVEMOS TODO EN EL RETURN DE LA VARIABLE DEL PRODUCTO	
            }
            else
            {
                Producto.msgError = "NO SE ENCUENTRA PRODUCTO. "+this.bd.msgError;
				prodResultado = null; //METEMOS LA VARIABLE EN EL OBJETO CUANDO NO EXISTE. 
            }
			
            return prodResultado;
        }
    }
}

