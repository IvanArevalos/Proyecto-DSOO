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

namespace FerreteriaLosPalomines
{
    public partial class Forminiciopersonal : Form
    {
        public Forminiciopersonal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {


        }
        private void btnPingresar_Click(object sender, EventArgs e)
        {

        }

        private void btnPingresar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string usuarioingresado = txtboxPersonal.Text;
                int contraseñaingresada = int.Parse(txtboxPcodigo.Text);
                string textoConexion = $"Server=localhost;Port={Globales.PORT};Database=los polvorines;Uid=root;Pwd=;";
                using (MySqlConnection conexion = new MySqlConnection(textoConexion))
                {
                    conexion.Open();
                    string consulta = "SELECT Usuario, Codigo, Nombre, Apellido, Dni, Telefono FROM personal WHERE Usuario=@Usuario AND Codigo=@Codigo";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Usuario", usuarioingresado);
                        comando.Parameters.AddWithValue("@Codigo", contraseñaingresada);

                        MySqlDataReader lector = comando.ExecuteReader();
                        if (lector.Read())
                        {
                            InicioPersonal ventanainicio=new InicioPersonal();
                            string nombreEmpleado = lector["Nombre"].ToString();
                            string apellidoEmpleado = lector["Apellido"].ToString();
                            string DniEmpleado = lector["Dni"].ToString();
                            string telefonoEmpleado = lector["Telefono"].ToString() ;
                            if (usuarioingresado == "Caja")
                            {
                                Actores.Personal empleadoactivo = new Actores.Personal(nombreEmpleado, apellidoEmpleado, DniEmpleado, telefonoEmpleado, "", "Caja");
                            }
                            if (usuarioingresado == "Gerencia")
                            {
                                Actores.Personal empleadoactivo = new Actores.Personal(nombreEmpleado, apellidoEmpleado, DniEmpleado, telefonoEmpleado, "", "Gerencia");
                            }
                            if (usuarioingresado == "Dueño")
                            {
                                Actores.Personal empleadoactivo = new Actores.Personal(nombreEmpleado, apellidoEmpleado, DniEmpleado, telefonoEmpleado, "", "Dueño");
                            }
                            MessageBox.Show($"Bienvenido {nombreEmpleado}");
                            ventanainicio.Show();
                        }
                        else
                        {
                            MessageBox.Show("Error, usuario o contraseña incorrectos");
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
