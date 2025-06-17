using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FerreteriaLosPalomines.Actores;

namespace FerreteriaLosPalomines
{
    internal class Actores
    {

        public class Personas
        {
            public string nombre { get; set; }
            public string apellido { get; set; }
            public string dni { get; set; }
            public string telefono { get; set; }
            public string email { get; set; }
        }
        public class Clientes : Personas
        {
            public Clientes(string nombre, string apellido, int dni, int telefono, string email)
            {
                this.nombre = nombre;
                this.apellido = apellido;
                this.dni = dni;
                this.telefono = telefono;
                this.email = email;
            }
        }
        public class Personal : Personas
        {
            public string rango { get; set; }
            public Personal(string nombre, string apellido, string dni, string telefono, string email, string rango)
            {
                this.nombre = nombre;
                this.apellido = apellido;
                this.dni = dni;
                this.telefono = telefono;
                this.email = email;
                this.rango = rango;
            }
        }
    }
    public class ProductoVenta
    {
        public int Dnicliente { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; } // "tornilleria", "indumentaria", etc.
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public ProductoVenta(int Dnicliente, string Nombre, string Categoria, int Cantidad, decimal Precio)
        {
            this.Dnicliente = Dnicliente;
            this.Nombre = Nombre;
            this.Categoria = Categoria;
            this.Precio = Precio;
            this.Cantidad = Cantidad;
        }
    }
    public class ProductoStock
    {
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public int Stock { get; set; }
        public decimal Costo { get; set; }
        public string Proveedor { get; set; }
        public decimal Precio_Bruto { get; set; }
        public ProductoStock(string nombre, string marca, int stock, decimal costo, string proveedor, decimal precio_Bruto)
        {
            Nombre = nombre;
            Marca = marca;
            Stock = stock;
            Costo = costo;
            Proveedor = proveedor;
            Precio_Bruto = precio_Bruto;
        }
    }
    public static class Globales
    {
        public static int PORT = 3306;
    }
}
