namespace FerreteriaLosPalomines
{
    partial class InventarioTornilleriaGerencia
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
            this.txtboxMarcaproducto = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvHerramientas = new System.Windows.Forms.DataGridView();
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
            this.txtboxNombreproducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxCantidadproducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxCostoproducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxProveedorproducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtboxPreciobrutoproducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.menuPersonal1 = new FerreteriaLosPalomines.MenuPersonal();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHerramientas)).BeginInit();
            this.Inventario.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo del producto";
            // 
            // txtboxCodigoproducto
            // 
            this.txtboxCodigoproducto.Location = new System.Drawing.Point(30, 86);
            this.txtboxCodigoproducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxCodigoproducto.Name = "txtboxCodigoproducto";
            this.txtboxCodigoproducto.Size = new System.Drawing.Size(120, 20);
            this.txtboxCodigoproducto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(383, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Marca del Producto";
            // 
            // txtboxMarcaproducto
            // 
            this.txtboxMarcaproducto.Location = new System.Drawing.Point(397, 86);
            this.txtboxMarcaproducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxMarcaproducto.Name = "txtboxMarcaproducto";
            this.txtboxMarcaproducto.Size = new System.Drawing.Size(120, 20);
            this.txtboxMarcaproducto.TabIndex = 4;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(596, 179);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(64, 29);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvHerramientas
            // 
            this.dgvHerramientas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHerramientas.Location = new System.Drawing.Point(12, 228);
            this.dgvHerramientas.Name = "dgvHerramientas";
            this.dgvHerramientas.Size = new System.Drawing.Size(802, 327);
            this.dgvHerramientas.TabIndex = 10;
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
            // txtboxNombreproducto
            // 
            this.txtboxNombreproducto.Location = new System.Drawing.Point(208, 86);
            this.txtboxNombreproducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxNombreproducto.Name = "txtboxNombreproducto";
            this.txtboxNombreproducto.Size = new System.Drawing.Size(120, 20);
            this.txtboxNombreproducto.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nombre del producto";
            // 
            // txtboxCantidadproducto
            // 
            this.txtboxCantidadproducto.Location = new System.Drawing.Point(591, 86);
            this.txtboxCantidadproducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxCantidadproducto.Name = "txtboxCantidadproducto";
            this.txtboxCantidadproducto.Size = new System.Drawing.Size(120, 20);
            this.txtboxCantidadproducto.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(575, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cantidad del Producto";
            // 
            // txtboxCostoproducto
            // 
            this.txtboxCostoproducto.Location = new System.Drawing.Point(24, 188);
            this.txtboxCostoproducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxCostoproducto.Name = "txtboxCostoproducto";
            this.txtboxCostoproducto.Size = new System.Drawing.Size(120, 20);
            this.txtboxCostoproducto.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Costo del Producto";
            // 
            // txtboxProveedorproducto
            // 
            this.txtboxProveedorproducto.Location = new System.Drawing.Point(208, 188);
            this.txtboxProveedorproducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxProveedorproducto.Name = "txtboxProveedorproducto";
            this.txtboxProveedorproducto.Size = new System.Drawing.Size(120, 20);
            this.txtboxProveedorproducto.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(192, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Proveedor del Producto";
            // 
            // txtboxPreciobrutoproducto
            // 
            this.txtboxPreciobrutoproducto.Location = new System.Drawing.Point(406, 188);
            this.txtboxPreciobrutoproducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxPreciobrutoproducto.Name = "txtboxPreciobrutoproducto";
            this.txtboxPreciobrutoproducto.Size = new System.Drawing.Size(120, 20);
            this.txtboxPreciobrutoproducto.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(377, 148);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Precio Bruto del Producto";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(677, 179);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(64, 29);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // menuPersonal1
            // 
            this.menuPersonal1.Location = new System.Drawing.Point(3, 3);
            this.menuPersonal1.Name = "menuPersonal1";
            this.menuPersonal1.Size = new System.Drawing.Size(1146, 28);
            this.menuPersonal1.TabIndex = 27;
            // 
            // InventarioTornilleriaGerencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 567);
            this.Controls.Add(this.menuPersonal1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtboxPreciobrutoproducto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtboxProveedorproducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtboxCostoproducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtboxCantidadproducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtboxNombreproducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvHerramientas);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtboxMarcaproducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxCodigoproducto);
            this.Controls.Add(this.label1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InventarioTornilleriaGerencia";
            this.Text = "Inventario Caja";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHerramientas)).EndInit();
            this.Inventario.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxCodigoproducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxMarcaproducto;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvHerramientas;
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
        private System.Windows.Forms.TextBox txtboxNombreproducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxCantidadproducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxCostoproducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtboxProveedorproducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtboxPreciobrutoproducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEliminar;
        private MenuPersonal menuPersonal1;
    }
}