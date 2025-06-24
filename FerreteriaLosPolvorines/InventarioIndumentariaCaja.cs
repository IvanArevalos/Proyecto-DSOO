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
    public partial class InventarioIndumentariaCaja : Form
    {
        public InventarioIndumentariaCaja()
        {
            InitializeComponent();
            MostrardatosgrillaIndumentaria();
        }
        public void MostrardatosgrillaIndumentaria()
        {
            try
            {
                string textoConexion = $"Server=localhost;Port={Globales.PORT};Database=los polvorines;Uid=root;Pwd=;";
                using (MySqlConnection conexion = new MySqlConnection(textoConexion))
                {
                    conexion.Open();
                    string consulta = "select * from indumentaria";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        using (MySqlDataAdapter datos = new MySqlDataAdapter(comando))
                        {
                            DataTable tabla = new DataTable();
                            datos.Fill(tabla);
                            dgvIndumentaria.DataSource = tabla;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            {
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigoproducto = int.Parse(txtboxCodigoproducto.Text);
                int cantidadproducto = int.Parse(txtboxCantidadproducto.Text);
                string textoConexion = $"Server=localhost;Port={Globales.PORT};Database=los polvorines;Uid=root;Pwd=;";
                using (MySqlConnection conexion = new MySqlConnection(textoConexion))
                {
                    conexion.Open();
                    string consulta = "UPDATE indumentaria set Stock=@Cantidad WHERE Codigo=@Codigo";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Cantidad", cantidadproducto);
                        comando.Parameters.AddWithValue("@Codigo", codigoproducto);

                        int columnasmodificadas = comando.ExecuteNonQuery();
                        if (columnasmodificadas > 0)
                        {
                            MostrardatosgrillaIndumentaria();
                        }
                        else
                        {
                            MessageBox.Show("Error, sus datos no se editaron");
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
