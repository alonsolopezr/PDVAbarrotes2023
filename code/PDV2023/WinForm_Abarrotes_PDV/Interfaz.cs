using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WinForm_Abarrotes_PDV;

namespace pruebaVENTA
{
    public partial class Interfaz : Form
    {
        public Interfaz()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 45;
            }
            else
            {
                MenuVertical.Width = 250;
            }
        }

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll",EntryPoint ="SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd,int wmsg,int wparam,int Lparam);
        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Normal;
            iconmaximizar.Visible = true;
            iconrestaurar.Visible = false;
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void AbrirFormInPanel(object Formhijo)
        {
            if(this.panelContenedor.Controls.Count > 0) 
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

        }
        private void AgregarProducto_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Guardar());
        }

        private void Productos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Caja());
        }

        private void EliminarProductos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Eliminar());
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Editar());
        }
    }
}
