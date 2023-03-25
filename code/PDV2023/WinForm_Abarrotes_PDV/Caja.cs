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

namespace WinForm_Abarrotes_PDV
{
    public partial class Caja : Form
    {
        //instanca de Producto
        Producto prodAVender;
        public Caja()
        {
            InitializeComponent();
            prodAVender= new Producto();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //vamos a consultar en productos por el cod de barras del TXTBarras
            Producto res = prodAVender.consultarPorCodBarras(txtCodBarras.Text);
            //validamos que si exista
            if (res == null)
            {
                MessageBox.Show("Producto no existe en el catalogo..." + Producto.msgError);
            }
            else {
                //si existe prod, vamos a crear un renglon en el data grid
                dGridVentas.Rows.Add(new object[] { res.id, res.nombre, res.precio, numericCantidad.Value, res.precio * double.Parse(numericCantidad.Value.ToString()) });
                //en la ultima columna, vamos a poner la multiplicacion de cantidad por precio del prod
                //limpiamos txtxCODBARRAS y cantidad
                txtCodBarras.Clear();
                numericCantidad.Value = 1;
                int col = dGridVentas.ColumnCount - 1;
                double subtotal = 0;
                //totalizar 
                for (int i = 1; i < dGridVentas.Rows.Count; i++)
                {
                    subtotal += double.Parse(dGridVentas.Rows[i].Cells[col].Value.ToString());

                }
                txtTotal.Text= subtotal.ToString();
            }


        }
    }
}
