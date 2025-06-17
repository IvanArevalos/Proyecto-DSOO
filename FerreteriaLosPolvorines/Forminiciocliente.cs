using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FerreteriaLosPalomines
{
    public partial class Forminiciocliente : Form
    {
        public Forminiciocliente()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lnklblregistrocliente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Formregistrocliente ventanaregistrocliente=new Formregistrocliente();
            ventanaregistrocliente.Show();
            this.Hide();
        }

        private void btningreso_Click(object sender, EventArgs e)
        {
            try
            {
                string usuarioingresado = txtboxusuario.Text;
                string passwordingresado = txtboxpassword.Text;
                txtboxusuario.Clear();
                txtboxpassword.Clear();

                string textoConexion = "Server=localhost;Database=los polvorines;Uid=root;Pwd=;";
                using (MySqlConnection conexion = new MySqlConnection(textoConexion))
                {
                    conexion.Open();

                    string consulta = "SELECT * FROM clientes WHERE Usuario=@Usuario AND Password=@Password";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Usuario", usuarioingresado);
                        comando.Parameters.AddWithValue("@Password", passwordingresado);



                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                        
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);


            }
        }   
    }
}
