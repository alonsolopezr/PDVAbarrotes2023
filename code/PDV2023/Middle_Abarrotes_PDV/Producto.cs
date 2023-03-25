using System;
using Back_CRUDs_BD;

namespace Middle_Abarrotes_PDV
{
	public class Producto
	{
		//propiedades de la clase
		public string nombre;
		public string descripcion;
		public double precio;
		public string cod_barras;
		public string imagen;
		public string marca;
		public Presentacion unidad;
		public int id;
		//vars para reutilizar el CRUD
		CRUDs_BD bd;
		//var statis de  msg de error
		public static string msgError;

		public Producto()
		{
			//crear una instancia de MYSQL a mi bd
			bd = new Back_CRUDs_BD.MySql("localhost", "root", "", "pdvabarrotes_bd", "3306");
		}

		//métodos de la clase CRUD
		public bool crear(string nom, string desc, double precio, string cod_barras, string imagen, string marca, Presentacion unidad) {
			List<string> nombresCampos = new List<string>()
			{
                    "nombre", "descripcion", "precio", "cod_barras", "imagen", "marca", "unidad"
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
		}//crear


        public bool modificar(string nom, string desc, double precio, string cod_barras, string imagen, string marca, Presentacion unidad, int id)
        {
            List<string> nombresCampos = new List<string>()
            {
                    "nombre", "descripcion", "precio", "cod_barras", "imagen", "marca", "unidad"
            };

            List<ValoresAInsertar> vals = new List<ValoresAInsertar>();
            vals.Add(new ValoresAInsertar(nom));
            vals.Add(new ValoresAInsertar(desc));
            vals.Add(new ValoresAInsertar(precio.ToString(), false));
            vals.Add(new ValoresAInsertar(cod_barras));
            vals.Add(new ValoresAInsertar(imagen));
            vals.Add(new ValoresAInsertar(unidad.ToString()));

            bool resultado = this.bd.modificar("productos", nombresCampos, vals, id);
            //valir el res
            if (resultado == false)
                Producto.msgError = this.bd.msgError;

            return resultado;
        }//crear

		//borrar
		public bool borrar(int id) {
			bool res = this.bd.borrar("productos", id);
			if (res = false)
				Producto.msgError = this.bd.msgError;
			return res;
		}

		//consultar
		public List<object[]> consultarTodos() {
			return this.bd.consulta("productos");
		}

		//consultar Precio por ID de producto
		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <returns>El precio del producto con id consultado, o -1 para indicar un error.</returns>
		public double consultarPrecio(int id) {
			double precio = 0;
			List<object[]> res = this.bd.consulta("productos", "id=" + id);
			//validamos que traig un elemento la lista
			if (res.Count == 1)
			{
				object[] tempo = res[0];
				precio = double.Parse(tempo[3].ToString());
			}
			else {
				Producto.msgError = this.bd.msgError;
				precio = -1;
			}

			return precio;
		}

        public Producto consultarPorCodBarras(string codBarras)
        {
			Producto prodResultado = new Producto();

            List<object[]> res = this.bd.consulta("productos", "cod_barras=" + codBarras);
            //validamos que traig un elemento la lista
            if (res.Count == 1)
            {
				Presentacion presentacionTexto ;
                object[] tempo = res[0];
				prodResultado.id = int.Parse(tempo[0].ToString());
				prodResultado.nombre = tempo[1].ToString();
				prodResultado.descripcion = tempo[2].ToString();
                prodResultado.precio = double.Parse(tempo[3].ToString());
				prodResultado.cod_barras = tempo[4].ToString();
				prodResultado.imagen = tempo[5].ToString();
				prodResultado.marca = tempo[6].ToString();

				switch (tempo[7].ToString())
				{
					case "CAJA":
						presentacionTexto = Presentacion.CAJA;
                        break;
					case "KILO":
						presentacionTexto = Presentacion.KILO;
                        break;
					case "LITRO":
						presentacionTexto = Presentacion.LITRO;
                        break;
					case "PIEZA":
						presentacionTexto = Presentacion.PIEZA;
                        break;
					default:
						presentacionTexto = Presentacion.KILO;
						break;

				}
				prodResultado.unidad = presentacionTexto;

            }
            else
            {
                Producto.msgError = "Código de barras no existe en catalogo de productos. "+this.bd.msgError;
				prodResultado = null;
            }

            return prodResultado;
        }
    }
}

