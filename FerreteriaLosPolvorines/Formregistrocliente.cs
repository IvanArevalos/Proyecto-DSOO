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
    public partial class Formregistrocliente : Form
    {
        public Formregistrocliente()
        {
            InitializeComponent();
        }

        private void lnklbliniciocliente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forminiciocliente ventanainiciocliente=new Forminiciocliente();
            ventanainiciocliente.Show();
            this.Close();
        }

        private void btnregistrocliente_Click(object sender, EventArgs e)
        {
            try
            {
                string nombrecliente = txtboxNombrecliente.Text;
                string apellidocliente = txtboxApellidocliente.Text;
                int dnicliente = int.Parse(txtboxDnicliente.Text);
                int telefonocliente = int.Parse(txtboxTelefonocliente.Text);
                string emailcliente = txtboxEmailcliente.Text;

                Actores.Clientes nuevocliente = new Actores.Clientes(nombrecliente,apellidocliente,dnicliente,telefonocliente,emailcliente);
                txtboxNombrecliente.Clear();
                txtboxApellidocliente.Clear();
                txtboxDnicliente.Clear();
                txtboxEmailcliente.Clear();
                txtboxTelefonocliente.Clear();

                string textoConexion = "Server=localhost;Database=los polvorines;Uid=root;Pwd=;";
                using (MySqlConnection conexion = new MySqlConnection(textoConexion))
                {
                    conexion.Open();

                    string consulta = "INSERT INTO clientes (Nombre, Apellido, Dni, Telefono, Email) " + "VALUES(@Nombre,@Apellido,@Dni, @Telefono, @Email)";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombre", nuevocliente.nombre);
                        comando.Parameters.AddWithValue("@Apellido", nuevocliente.apellido);
                        comando.Parameters.AddWithValue("@Dni", nuevocliente.dni);
                        comando.Parameters.AddWithValue("@Telefono", nuevocliente.telefono);
                        comando.Parameters.AddWithValue("@Email", nuevocliente.email);


                        int columnasmodificadas = comando.ExecuteNonQuery();
                        if (columnasmodificadas > 0)
                        {
                            MessageBox.Show("Sus datos se agregaron correctamente");
                        }
                        else
                        {
                            MessageBox.Show("Error, sus datos no se agregaron");
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
