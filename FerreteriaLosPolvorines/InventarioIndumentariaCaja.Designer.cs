namespace FerreteriaLosPalomines
{
    partial class InventarioIndumentariaCaja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxCodigoproducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxCantidadproducto = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvIndumentaria = new System.Windows.Forms.DataGridView();
            this.Inventario = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indumentariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tornilleriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPersonal1 = new FerreteriaLosPalomines.MenuPersonal();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndumentaria)).BeginInit();
            this.Inventario.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo del producto";
            // 
            // txtboxCodigoproducto
            // 
            this.txtboxCodigoproducto.Location = new System.Drawing.Point(47, 104);
            this.txtboxCodigoproducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxCodigoproducto.Name = "txtboxCodigoproducto";
            this.txtboxCodigoproducto.Size = new System.Drawing.Size(120, 20);
            this.txtboxCodigoproducto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad del Producto";
            // 
            // txtboxCantidadproducto
            // 
            this.txtboxCantidadproducto.Location = new System.Drawing.Point(47, 198);
            this.txtboxCantidadproducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxCantidadproducto.Name = "txtboxCantidadproducto";
            this.txtboxCantidadproducto.Size = new System.Drawing.Size(120, 20);
            this.txtboxCantidadproducto.TabIndex = 4;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(69, 237);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(64, 29);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvIndumentaria
            // 
            this.dgvIndumentaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIndumentaria.Location = new System.Drawing.Point(255, 40);
            this.dgvIndumentaria.Name = "dgvIndumentaria";
            this.dgvIndumentaria.Size = new System.Drawing.Size(501, 418);
            this.dgvIndumentaria.TabIndex = 10;
            // 
            // Inventario
            // 
            this.Inventario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.herramientasToolStripMenuItem,
            this.indumentariaToolStripMenuItem,
            this.tornilleriaToolStripMenuItem});
            this.Inventario.Name = "Inventario";
            this.Inventario.Size = new System.Drawing.Size(146, 70);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.modificarToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // indumentariaToolStripMenuItem
            // 
            this.indumentariaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem1,
            this.modificarToolStripMenuItem1});
            this.indumentariaToolStripMenuItem.Name = "indumentariaToolStripMenuItem";
            this.indumentariaToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.indumentariaToolStripMenuItem.Text = "Indumentaria";
            // 
            // agregarToolStripMenuItem1
            // 
            this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            this.agregarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.agregarToolStripMenuItem1.Text = "Agregar";
            // 
            // modificarToolStripMenuItem1
            // 
            this.modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            this.modificarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem1.Text = "Modificar";
            // 
            // tornilleriaToolStripMenuItem
            // 
            this.tornilleriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem2,
            this.modificarToolStripMenuItem2});
            this.tornilleriaToolStripMenuItem.Name = "tornilleriaToolStripMenuItem";
            this.tornilleriaToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.tornilleriaToolStripMenuItem.Text = "Tornilleria";
            // 
            // agregarToolStripMenuItem2
            // 
            this.agregarToolStripMenuItem2.Name = "agregarToolStripMenuItem2";
            this.agregarToolStripMenuItem2.Size = new System.Drawing.Size(125, 22);
            this.agregarToolStripMenuItem2.Text = "Agregar";
            // 
            // modificarToolStripMenuItem2
            // 
            this.modificarToolStripMenuItem2.Name = "modificarToolStripMenuItem2";
            this.modificarToolStripMenuItem2.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem2.Text = "Modificar";
            // 
            // menuPersonal1
            // 
            this.menuPersonal1.Location = new System.Drawing.Point(3, 3);
            this.menuPersonal1.Name = "menuPersonal1";
            this.menuPersonal1.Size = new System.Drawing.Size(1146, 28);
            this.menuPersonal1.TabIndex = 14;
            // 
            // InventarioIndumentariaCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 508);
            this.Controls.Add(this.menuPersonal1);
            this.Controls.Add(this.dgvIndumentaria);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtboxCantidadproducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxCodigoproducto);
            this.Controls.Add(this.label1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InventarioIndumentariaCaja";
            this.Text = "Inventario Caja";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndumentaria)).EndInit();
            this.Inventario.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxCodigoproducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxCantidadproducto;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvIndumentaria;
        private System.Windows.Forms.ContextMenuStrip Inventario;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indumentariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tornilleriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem2;
        private MenuPersonal menuPersonal1;
    }
}