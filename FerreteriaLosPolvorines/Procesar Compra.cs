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
using static FerreteriaLosPalomines.ProductoVenta;

namespace FerreteriaLosPalomines
{
    public partial class Procesar_Compra : Form
    {
        private List<ProductoVenta> carrito = new List<ProductoVenta>();
        public Procesar_Compra()
        {
            InitializeComponent();
            cmbCategoria.Items.Add("tornilleria");
            cmbCategoria.Items.Add("indumentaria");
            cmbCategoria.Items.Add("herramientas");
        }
        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string categoria = cmbCategoria.SelectedItem.ToString();
                cmbNombreProducto.Items.Clear();
                string textoconexion = $"Server=localhost;Port={Globales.PORT};Database=los polvorines;Uid=root;Pwd=;";
                using (MySqlConnection conexion = new MySqlConnection(textoconexion))
                {
                    conexion.Open();
                    string consulta = $"SELECT Nombre FROM `{categoria}`";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                cmbNombreProducto.Items.Add(lector["Nombre"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void btnCalcularprecio_Click(object sender, EventArgs e)
        {
            try
            {
                string categoriaproducto = cmbCategoria.SelectedItem.ToString();
                string nombreproducto = cmbNombreProducto.SelectedItem.ToString();
                int cantidadproducto = int.Parse(txtboxCantidadproducto.Text);
                string textoconexion = $"Server=localhost;Port={Globales.PORT};Database=los polvorines;Uid=root;Pwd=;";
                using (MySqlConnection conexion = new MySqlConnection(textoconexion))
                {
                    conexion.Open();
                    string consulta = $"SELECT Precio_bruto FROM `{categoriaproducto}` WHERE Nombre=@Nombre";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombre", nombreproducto);
                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                decimal precioUnitario = lector.GetDecimal("Precio_bruto");
                                decimal preciototal = precioUnitario * cantidadproducto;
                                txtboxPrecioproducto.Text = preciototal.ToString();
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el producto.");
                                return;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void btnagregarcarrito_Click(object sender, EventArgs e)
        {
            try
            {
                int dnicliente = int.Parse(txtboxDnicliente.Text);
                string categoriaproductocliente = cmbCategoria.SelectedItem.ToString();
                string nombreproductocliente = cmbNombreProducto.SelectedItem.ToString();
                int cantidadproductocliente = int.Parse(txtboxCantidadproducto.Text);
                decimal precioproductocliente = int.Parse(txtboxPrecioproducto.Text);
                ProductoVenta Factura = new ProductoVenta(dnicliente,nombreproductocliente, categoriaproductocliente, cantidadproductocliente, precioproductocliente);
                carrito.Add(Factura);
                RefrescarCarrito();
                txtboxCantidadproducto.Clear();
                txtboxPrecioproducto.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar al carrito: " + ex.Message);
            }
        }
        private void RefrescarCarrito()
        {
            dgvCarrito.DataSource = null;
            dgvCarrito.DataSource = carrito;
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (carrito.Count == 0)
            {
                MessageBox.Show("El carrito está vacío.");
                return;
            }

            try
            {
                string textoconexion = $"Server=localhost;Port={Globales.PORT};Database=los polvorines;Uid=root;Pwd=;";

                using (MySqlConnection conexion = new MySqlConnection(textoconexion))
                {
                    conexion.Open();

                    foreach (var item in carrito)
                    {
                        string consulta = @"INSERT INTO facturas 
                                    (Dni, Fecha_Factura, Categoria, Nombre_Producto, Precio_Total_Producto, Cantidad_Producto) 
                                    VALUES (@Dni, @Fecha, @Categoria, @NombreProducto, @PrecioTotal, @Cantidad)";

                        using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                        {
                            comando.Parameters.AddWithValue("@Dni", item.Dnicliente);
                            comando.Parameters.AddWithValue("@Fecha", DateTime.Now);
                            comando.Parameters.AddWithValue("@Categoria", item.Categoria);
                            comando.Parameters.AddWithValue("@NombreProducto", item.Nombre);
                            comando.Parameters.AddWithValue("@PrecioTotal", item.Precio);
                            comando.Parameters.AddWithValue("@Cantidad", item.Cantidad);

                            comando.ExecuteNonQuery();
                        }
                        string consultarefresco = $@"UPDATE `{item.Categoria}` SET Stock=Stock-@Cantidad WHERE Nombre=@NombreProducto";
                        using (MySqlCommand comandoUpdate = new MySqlCommand(consultarefresco, conexion))
                        {
                            comandoUpdate.Parameters.AddWithValue("@Cantidad", item.Cantidad);
                            comandoUpdate.Parameters.AddWithValue("@NombreProducto", item.Nombre);
                            comandoUpdate.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Factura generada correctamente.");
                carrito.Clear();
                RefrescarCarrito();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al facturar: " + ex.Message);
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
