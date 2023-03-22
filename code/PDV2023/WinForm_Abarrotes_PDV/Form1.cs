using Middle_Abarrotes_PDV;

namespace WinForm_Abarrotes_PDV
{
    public partial class Form1 : Form
    {
        //crear una instancia de producto
        Producto prod = new Producto();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Presentacion valorPresentacion;
            //convertir de string a PResentacion
            switch (comboPresentacion.SelectedItem.ToString()) {
                case "CAJA":
                    valorPresentacion = Presentacion.CAJA; break;
                case "LITRO": 
                    valorPresentacion = Presentacion.LITRO; break;
                case "KILO":
                    valorPresentacion = Presentacion.KILO; break;
                case "PIEZA":
                    valorPresentacion = Presentacion.PIEZA; break;
                default:
                    valorPresentacion = Presentacion.KILO; break;


            }

           bool resultado =  prod.crear(txtNom.Text, txtDesc.Text, double.Parse(txtPrecio.Text), txtCodBarras.Text, txtImagen.Text, txtMarca.Text, valorPresentacion);
            if (resultado == false)
            {
                MessageBox.Show("ERROR AL GUARDAR " + Producto.msgError);
            }
            else {
                MessageBox.Show("Producto registrado correctamewnte");
            }
        }
    }
}