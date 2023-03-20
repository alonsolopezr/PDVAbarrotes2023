using Middle_gamestore_PDV;
using System.Windows.Media.Media3D;
using System.Windows.Forms;
using Back_CRUDs_BD;

namespace WinForm_gamestore_pdv
{
    public partial class FormProducto : Form
    {
        //Creamos una instancia de producto
        Producto prod = new Producto(); //un tipo de producto vacio. 
        CRUDs_BD bd;//para utilizar la conexión a la bd
        List<Producto[]> list = new List<Producto[]>();//lista para añadirlo al data
        public FormProducto()
        {
            InitializeComponent();
            bd = new Back_CRUDs_BD.MySql("localhost", "root", "", "gamestore_pdv", "3306");
        }
        private void iconAñadir_Click(object sender, EventArgs e) //Habilitaremos los txt, con el evento clic añadir '+'
        {
            if (txtNombre.Enabled == false && txtDescripcion.Enabled == false
                && txtPrecio.Enabled == false && txtCodBarra.Enabled == false
                && txtImagen.Enabled == false && iconImagen.Enabled == false)
            {
                this.limpiarForm(true);
            }
        }
        private void iconCrear_Click(object sender, EventArgs e)
        {
            Consola valorConsola;
            //Valoramos que tipo de consola eligió el usuario. 
            switch (comboConsola.SelectedItem.ToString())
            {
                case "XBOX":
                    valorConsola = Consola.XBOX;
                    break;
                case "PLAYSTATION":
                    valorConsola = Consola.PLAYSTATION;
                    break;
                case "WI":
                    valorConsola = Consola.WI;
                    break;
                case "NINTENDO":
                    valorConsola = Consola.NINTENDO;
                    break;
                case "PC":
                    valorConsola = Consola.PC;
                    break;
                default:
                    valorConsola = Consola.XBOX;
                    break;
            }
            bool resultado = prod.crear(txtNombre.Text, txtDescripcion.Text, double.Parse(txtPrecio.Text), txtCodBarra.Text, txtImagen.Text, valorConsola);//Con esto metemos en el insert
            if (resultado == false)
            {
                MessageBox.Show("ERROR AL CARGAR PRODUCTO" + Producto.msgError);
            }
            else
            {
                MessageBox.Show("PRODUCTO CARGADO CON ÉXITO");
            }
        }
        private void iconEditar_Click(object sender, EventArgs e)
        {
            int id = 0;
            Consola valorConsola;
            //Valoramos que tipo de consola eligió el usuario. 
            switch (comboConsola.SelectedItem.ToString())
            {
                case "XBOX":
                    valorConsola = Consola.XBOX;
                    break;
                case "PLAYSTATION":
                    valorConsola = Consola.PLAYSTATION;
                    break;
                case "WI":
                    valorConsola = Consola.WI;
                    break;
                case "NINTENDO":
                    valorConsola = Consola.NINTENDO;
                    break;
                case "PC":
                    valorConsola = Consola.PC;
                    break;
                default:
                    valorConsola = Consola.XBOX;
                    break;
            }
            bool resultado = prod.modificar(txtNombre.Text, txtDescripcion.Text, double.Parse(txtPrecio.Text), txtCodBarra.Text, txtImagen.Text, valorConsola, id);
            if (resultado == false)
            {
                MessageBox.Show("ERROR AL MODIFICAR PRODUCTO" + Producto.msgError);
            }
            else
            {
                MessageBox.Show("PRODUCTO MODIFICADO CON ÉXITO");
            }
        }
        private void iconBorrar_Click(object sender, EventArgs e)
        {
            int id = 0;
            bool resultado = prod.borrar(id);
            if (resultado == false)
            {
                MessageBox.Show("ERROR AL ELIMINAR DATOS " + Producto.msgError);
            }
            else
            {
                MessageBox.Show("PRODUCTO ELIMINADO CON ÉXITO");
            }
        }
        //Inicializaremos el método para habilitar y limpiar el form. 
        public void limpiarForm(bool habilita)
        {
            if (habilita)
            {
                //habilitamos y limpiamos los texts
                txtNombre.Enabled = true;
                txtNombre.Clear();
                txtDescripcion.Enabled = true;
                txtDescripcion.Clear();
                txtCodBarra.Enabled = true;
                txtCodBarra.Clear();
                txtPrecio.Enabled = true;
                txtPrecio.Clear();
                txtImagen.Enabled = true;
                txtImagen.Clear();
                comboConsola.Enabled = true;
                iconImagen.Enabled = true;
            }
            else
            {
                //habilitamos y limpiamos los texts
                txtNombre.Enabled = false;
                txtNombre.Clear();
                txtDescripcion.Enabled = false;
                txtDescripcion.Clear();
                txtCodBarra.Enabled = false;
                txtCodBarra.Clear();
                txtPrecio.Enabled = false;
                txtPrecio.Clear();
                txtImagen.Enabled = false;
                txtImagen.Clear();
                comboConsola.Enabled = false;
                iconImagen.Enabled = false;
            }

        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            List<object[]> lista = prod.consultarTodos();
            for (int i = 0; i < dataGridProductos.RowCount; i++)
            {
                while (dataGridProductos.ReadOnly)
                {
                    dataGridProductos.Rows.Add(
                        lista
                        );
                }
            }
        }
    }
}