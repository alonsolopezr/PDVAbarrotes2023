using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Back_CRUDs_BD;


namespace pruebaVENTA
{
    public partial class Login : Form
    {
        int id = 0;
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=productos_pdv;Uid=root;Pwd=;");
        MySqlCommand commando = new MySqlCommand("SELECT * FROM usuarios");
        MySqlDataReader dr;
        
        public Login()
        {
            InitializeComponent();
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelarLogin_Click(object sender, EventArgs e)
        {
            textBoxUsuario.Clear();
            textboxPassword.Clear();

        }

        private void AceptarLogin_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {                
                con.Open();
            }
    
            commando = new MySqlCommand("SELECT * FROM usuarios WHERE nombre='"
                + textBoxUsuario.Text + "' AND password='" + textboxPassword.Text + "'");
      
            commando.Connection = con;
          
            dr = commando.ExecuteReader();
      
            if (dr.HasRows)
            {
                Interfaz interfaz = new Interfaz();
                this.Hide();
                interfaz.Show();

            }
            else
            {
                MessageBox.Show("No hay USUARIOS registrados aún...");
            }
         
            con.Close();
        }
    }
}
