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
    public partial class InventarioTornilleriaCaja : Form
    {
        public InventarioTornilleriaCaja()
        {
            InitializeComponent();
            Mostrardatosgrillatornilleria();
        }
        public void Mostrardatosgrillatornilleria()
        {
            try
            {
                string textoConexion = $"Server=localhost;Port={Globales.PORT};Database=los polvorines;Uid=root;Pwd=;";
                using (MySqlConnection conexion = new MySqlConnection(textoConexion))
                {
                    conexion.Open();
                    string consulta = "select * from tornilleria";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        using (MySqlDataAdapter datos = new MySqlDataAdapter(comando))
                        {
                            DataTable tabla = new DataTable();
                            datos.Fill(tabla);
                            dgvTornilleria.DataSource = tabla;
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
                    string consulta = "UPDATE tornilleria set Stock=@Cantidad WHERE Codigo=@Codigo";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Cantidad", cantidadproducto);
                        comando.Parameters.AddWithValue("@Codigo", codigoproducto);

                        int columnasmodificadas = comando.ExecuteNonQuery();
                        if (columnasmodificadas > 0)
                        {
                            Mostrardatosgrillatornilleria();
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
        private void procesarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Procesar_Compra ventanaprocesar = new Procesar_Compra();
            ventanaprocesar.MdiParent = this;
            ventanaprocesar.Show();
        }

        private void herramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventarioHerramientas ventanainventarioherramientascaja = new InventarioHerramientas();
            ventanainventarioherramientascaja.Show();
        }

        private void indumentariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventarioIndumentariaCaja ventanainventarioindumentariacaja = new InventarioIndumentariaCaja();
            ventanainventarioindumentariacaja.Show();
        }

        private void tornilleriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventarioTornilleriaCaja ventanainventariotornilleriacaja = new InventarioTornilleriaCaja();
            ventanainventariotornilleriacaja.Show();
        }

        private void historialDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Historialdefacturascaja ventanahistorialfacturascaja = new Historialdefacturascaja();
            ventanahistorialfacturascaja.Show();
        }
    }
}
