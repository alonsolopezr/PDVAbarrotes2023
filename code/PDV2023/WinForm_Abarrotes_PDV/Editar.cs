using Middle_Abarrotes_PDV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Back_CRUDs_BD;

namespace pruebaVENTA
{
    public partial class Editar : Form
    {
        Producto prod = new Producto();
        public Editar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Presentacion valorPresentacion;
            //convertir de string a PResentacion
            switch (comboPresentacion.SelectedItem.ToString())
            {
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

            bool resultado = prod.modificar(txtNom.Text, txtDesc.Text, double.Parse(txtPrecio.Text), txtCodBarras.Text, txtImagen.Text, txtMarca.Text, valorPresentacion);
            if (resultado == false)
            {
                MessageBox.Show("ERROR AL MODIFICAR " + Producto.msgError);
            }
            else
            {
                MessageBox.Show("Producto Modificado correctamewnte");
            }
        }
    }
}
