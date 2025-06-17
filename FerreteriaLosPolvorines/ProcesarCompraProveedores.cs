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
using static FerreteriaLosPalomines.ProductoStock;

namespace FerreteriaLosPalomines
{
    public partial class ProcesarCompraProveedores : Form
    {
        private List<ProductoStock> carrito = new List<ProductoStock>();
        public ProcesarCompraProveedores()
        {
            InitializeComponent();
        }
        private void btnagregarcarrito_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreproducto = txtboxNombreproducto.Text;
                string marcaproducto=txtboxMarcaproducto.Text;
                int stockproducto = int.Parse(txtboxStockproducto.Text);
                decimal costoproducto = decimal.Parse(txtboxCostoproducto.Text);
                string proveedorproducto = txtboxProveedorproducto.Text;
                decimal preciobrutoproducto = decimal.Parse(txtboxPreciobrutoproducto.Text);
                ProductoStock Factura = new ProductoStock(nombreproducto,marcaproducto,stockproducto,costoproducto,proveedorproducto,preciobrutoproducto);
                carrito.Add(Factura);
                RefrescarCarrito();
                txtboxStockproducto.Clear();
                txtboxCostoproducto.Clear();
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
                        string consulta = @"INSERT INTO herramientas 
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
