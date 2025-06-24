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
    public partial class ProcesarCompraProveedoresTornilleria : Form
    {
        private List<ProductoStock> carrito = new List<ProductoStock>();
        public ProcesarCompraProveedoresTornilleria()
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
                        DateTime fechaActual= DateTime.Now;
                        string consultaExistente= @"SELECT COUNT(*) FROM tornilleria WHERE Nombre=@Nombre AND Marca=@Marca AND Costo=@Costo AND Proveedor=@Proveedor AND Precio_bruto=@Precio_bruto";

                        using (MySqlCommand comandoExistente= new MySqlCommand(consultaExistente, conexion))
                        {
                            comandoExistente.Parameters.AddWithValue("@Nombre", item.Nombre);
                            comandoExistente.Parameters.AddWithValue("@Marca", item.Marca);
                            comandoExistente.Parameters.AddWithValue("@Costo", item.Costo);
                            comandoExistente.Parameters.AddWithValue("@Proveedor", item.Proveedor);
                            comandoExistente.Parameters.AddWithValue("@Precio_bruto", item.Precio_Bruto);
                            int existe=Convert.ToInt32(comandoExistente.ExecuteScalar());
                            if (existe > 0)
                            {
                                string update = @"UPDATE tornilleria SET Stock=Stock+@Stock WHERE Nombre=@Nombre AND Marca=@Marca AND Costo=@Costo AND Proveedor=@Proveedor AND Precio_bruto=@Precio_bruto";
                                using (MySqlCommand cmdUpdate = new MySqlCommand(update, conexion))
                                {
                                    cmdUpdate.Parameters.AddWithValue("@Stock", item.Stock);
                                    cmdUpdate.Parameters.AddWithValue("@Nombre", item.Nombre);
                                    cmdUpdate.Parameters.AddWithValue("@Marca", item.Marca);
                                    cmdUpdate.Parameters.AddWithValue("@Costo", item.Costo);
                                    cmdUpdate.Parameters.AddWithValue("@Proveedor", item.Proveedor);
                                    cmdUpdate.Parameters.AddWithValue("@Precio_bruto", item.Precio_Bruto);

                                    cmdUpdate.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                string consultainsert = @"INSERT INTO tornilleria (Nombre,Marca,Stock,Costo,Proveedor,Precio_Bruto) VALUES (@Nombre,@Marca,@Stock,@Costo,@Proveedor,@Precio_bruto)";
                                using (MySqlCommand cmdinsert = new MySqlCommand(consultainsert, conexion))
                                {
                                    cmdinsert.Parameters.AddWithValue("@Nombre", item.Nombre);
                                    cmdinsert.Parameters.AddWithValue("@Marca", item.Marca);
                                    cmdinsert.Parameters.AddWithValue("@Stock", item.Stock);
                                    cmdinsert.Parameters.AddWithValue("@Costo", item.Costo);
                                    cmdinsert.Parameters.AddWithValue("@Proveedor", item.Proveedor);
                                    cmdinsert.Parameters.AddWithValue("@Precio_bruto", item.Precio_Bruto);
                                    cmdinsert.ExecuteNonQuery();
                                }
                            }
                        }
                        string insertHistorial = @"INSERT INTO ingreso_stock (Nombre, Categoria, Marca, Proveedor,Cantidad_Agregada,Fecha_Ingreso) VALUES (@Nombre,@Categoria,@Marca,@Proveedor,@Cantidad_Agregada,@Fecha_Ingreso)";
                        using (MySqlCommand cmdHistorial = new MySqlCommand(insertHistorial, conexion))
                        {
                            cmdHistorial.Parameters.AddWithValue("@Nombre", item.Nombre);
                            cmdHistorial.Parameters.AddWithValue("@Categoria", "herramientas");
                            cmdHistorial.Parameters.AddWithValue("@Marca", item.Marca);
                            cmdHistorial.Parameters.AddWithValue("@Proveedor", item.Proveedor);
                            cmdHistorial.Parameters.AddWithValue("@Cantidad_Agregada", item.Stock);
                            cmdHistorial.Parameters.AddWithValue("@Fecha_Ingreso", fechaActual);
                            cmdHistorial.ExecuteNonQuery();
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
    }
}
