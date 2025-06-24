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
    public partial class MenuPersonal : UserControl
    {
        public MenuPersonal()
        {
            InitializeComponent();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InicioPersonal ventanainicio = new InicioPersonal();
            ventanainicio.Show();
            this.ParentForm.Hide(); // Oculta el form actual
        }

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Formregistrocliente().Show();
        }

        private void procesarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Procesar_Compra().Show();
        }

        private void historialDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Historialdefacturascaja().Show();
        }

        private void herramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InventarioHerramientasCaja().Show();
        }

        private void indumentariaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new InventarioIndumentariaCaja().Show();
        }

        private void tornilleriaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new InventarioTornilleriaCaja().Show();
        }

        private void herramientasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ProcesarCompraProveedoresHerramientas().Show();
        }

        private void indumentariaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ProcesarCompraProveedoresIndumentaria().Show();
        }

        private void tornilleriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ProcesarCompraProveedoresTornilleria().Show();
        }

        private void herramientasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new InventarioHerramientasGerencia().Show();
        }

        private void indumentariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InventarioIndumentariaGerencia().Show();
        }

        private void tornilleriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InventarioTornilleriaGerencia().Show();
        }
    }
}
