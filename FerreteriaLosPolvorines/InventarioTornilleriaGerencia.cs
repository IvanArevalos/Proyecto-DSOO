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
    public partial class InventarioTornilleriaGerencia : Form
    {
        public InventarioTornilleriaGerencia()
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
                string nombreproducto=txtboxNombreproducto.Text;
                string marcaproducto=txtboxMarcaproducto.Text;
                string costoproducto = txtboxCostoproducto.Text;
                string proveedorproducto=txtboxProveedorproducto.Text;
                string preciobrutoproducto = txtboxPreciobrutoproducto.Text;
                string codigoproducto = txtboxCodigoproducto.Text;
                string cantidadproducto = txtboxCantidadproducto.Text;
                string textoConexion = $"Server=localhost;Port={Globales.PORT};Database=los polvorines;Uid=root;Pwd=;";
                if (!string.IsNullOrWhiteSpace(txtboxCantidadproducto.Text) &&
                    string.IsNullOrWhiteSpace(txtboxNombreproducto.Text) &&
                   string.IsNullOrWhiteSpace(txtboxMarcaproducto.Text) &&
                   string.IsNullOrWhiteSpace(txtboxCostoproducto.Text) &&
                   string.IsNullOrWhiteSpace(txtboxProveedorproducto.Text) &&
                   string.IsNullOrWhiteSpace(txtboxPreciobrutoproducto.Text))
                {
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
                if (!string.IsNullOrWhiteSpace(txtboxNombreproducto.Text) &&
                    string.IsNullOrWhiteSpace(txtboxCantidadproducto.Text) &&
                   string.IsNullOrWhiteSpace(txtboxMarcaproducto.Text) &&
                   string.IsNullOrWhiteSpace(txtboxCostoproducto.Text) &&
                   string.IsNullOrWhiteSpace(txtboxProveedorproducto.Text) &&
                   string.IsNullOrWhiteSpace(txtboxPreciobrutoproducto.Text))
                {
                    using (MySqlConnection conexion = new MySqlConnection(textoConexion))
                    {
                        conexion.Open();
                        string consulta = "UPDATE tornilleria set Nombre=@Nombre WHERE Codigo=@Codigo";
                        using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                        {
                            comando.Parameters.AddWithValue("@Nombre", nombreproducto);
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
                if (!string.IsNullOrWhiteSpace(txtboxMarcaproducto.Text) &&
                    string.IsNullOrWhiteSpace(txtboxNombreproducto.Text) &&
                   string.IsNullOrWhiteSpace(txtboxCantidadproducto.Text) &&
                   string.IsNullOrWhiteSpace(txtboxCostoproducto.Text) &&
                   string.IsNullOrWhiteSpace(txtboxProveedorproducto.Text) &&
                   string.IsNullOrWhiteSpace(txtboxPreciobrutoproducto.Text))
                {
                    using (MySqlConnection conexion = new MySqlConnection(textoConexion))
                    {
                        conexion.Open();
                        string consulta = "UPDATE tornilleria set Marca=@Marca WHERE Codigo=@Codigo";
                        using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                        {
                            comando.Parameters.AddWithValue("@Marca", marcaproducto);
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
                if (!string.IsNullOrWhiteSpace(txtboxCostoproducto.Text) &&
                    string.IsNullOrWhiteSpace(txtboxNombreproducto.Text) &&
                   string.IsNullOrWhiteSpace(txtboxMarcaproducto.Text) &&
                   string.IsNullOrWhiteSpace(txtboxCantidadproducto.Text) &&
                   string.IsNullOrWhiteSpace(txtboxProveedorproducto.Text) &&
                   string.IsNullOrWhiteSpace(txtboxPreciobrutoproducto.Text))
                {
                    using (MySqlConnection conexion = new MySqlConnection(textoConexion))
                    {
                        conexion.Open();
                        string consulta = "UPDATE tornilleria set Costo=@Costo WHERE Codigo=@Codigo";
                        using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                        {
                            comando.Parameters.AddWithValue("@Costo", costoproducto);
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
                if (!string.IsNullOrWhiteSpace(txtboxProveedorproducto.Text) &&
                    string.IsNullOrWhiteSpace(txtboxNombreproducto.Text) &&
                   string.IsNullOrWhiteSpace(txtboxMarcaproducto.Text) &&
                   string.IsNullOrWhiteSpace(txtboxCostoproducto.Text) &&
                   string.IsNullOrWhiteSpace(txtboxCantidadproducto.Text) &&
                   string.IsNullOrWhiteSpace(txtboxPreciobrutoproducto.Text))
                {
                    using (MySqlConnection conexion = new MySqlConnection(textoConexion))
                    {
                        conexion.Open();
                        string consulta = "UPDATE tornilleria set Proveedor=@Proveedor WHERE Codigo=@Codigo";
                        using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                        {
                            comando.Parameters.AddWithValue("@Proveedor", proveedorproducto);
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
                if (!string.IsNullOrWhiteSpace(txtboxPreciobrutoproducto.Text) &&
                    string.IsNullOrWhiteSpace(txtboxNombreproducto.Text) &&
                   string.IsNullOrWhiteSpace(txtboxMarcaproducto.Text) &&
                   string.IsNullOrWhiteSpace(txtboxCostoproducto.Text) &&
                   string.IsNullOrWhiteSpace(txtboxProveedorproducto.Text) &&
                   string.IsNullOrWhiteSpace(txtboxCantidadproducto.Text))
                {
                    using (MySqlConnection conexion = new MySqlConnection(textoConexion))
                    {
                        conexion.Open();
                        string consulta = "UPDATE tornilleria set Precio_bruto=@Precio_bruto WHERE Codigo=@Codigo";
                        using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                        {
                            comando.Parameters.AddWithValue("@Precio_bruto", preciobrutoproducto);
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

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigoproducto = int.Parse(txtboxCodigoproducto.Text);
                string textoConexion = $"Server=localhost;Port={Globales.PORT};Database=los polvorines;Uid=root;Pwd=;";
                using (MySqlConnection conexion = new MySqlConnection(textoConexion))
                {
                    conexion.Open();
                    string consulta = "DELETE FROM tornilleria WHERE Codigo=@Codigo";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Codigo", codigoproducto);

                        int columnasmodificadas = comando.ExecuteNonQuery();
                        if (columnasmodificadas > 0)
                        {
                            Mostrardatosgrillatornilleria();
                        }
                        else
                        {
                            MessageBox.Show("Error, sus datos no se borraron");
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
