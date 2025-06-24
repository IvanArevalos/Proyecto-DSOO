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
    public partial class InventarioHerramientasCaja : Form
    {
        public InventarioHerramientasCaja()
        {
            InitializeComponent();
            Mostrardatosgrillaherramientas();
        }
        public void Mostrardatosgrillaherramientas()
        {
            try
            {
                string textoConexion = $"Server=localhost;Port={Globales.PORT};Database=los polvorines;Uid=root;Pwd=;";
                using (MySqlConnection conexion = new MySqlConnection(textoConexion))
                {
                    conexion.Open();
                    string consulta = "select * from herramientas";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        using (MySqlDataAdapter datos = new MySqlDataAdapter(comando))
                        {
                            DataTable tabla = new DataTable();
                            datos.Fill(tabla);
                            dgvHerramientas.DataSource = tabla;
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
                    string consulta = "UPDATE herramientas set Stock=@Cantidad WHERE Codigo=@Codigo";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Cantidad", cantidadproducto);
                        comando.Parameters.AddWithValue("@Codigo", codigoproducto);

                        int columnasmodificadas = comando.ExecuteNonQuery();
                        if (columnasmodificadas > 0)
                        {
                            Mostrardatosgrillaherramientas();
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
