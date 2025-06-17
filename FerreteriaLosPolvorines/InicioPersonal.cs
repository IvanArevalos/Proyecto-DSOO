using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreteriaLosPalomines
{
    public partial class InicioPersonal : Form
    {
        public InicioPersonal()
        {
            InitializeComponent();
        }

        private void procesarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Procesar_Compra ventanaprocesar=new Procesar_Compra();
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
            Historialdefacturascaja ventanahistorialfacturascaja=new Historialdefacturascaja();
            ventanahistorialfacturascaja.Show();
        }
    }
}
