﻿namespace FerreteriaLosPalomines
{
    partial class Procesar_Compra
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnagregarcarrito = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxPrecioproducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.txtboxCantidadproducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbNombreProducto = new System.Windows.Forms.ComboBox();
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.cmbDnicliente = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtboxNombrecliente = new System.Windows.Forms.TextBox();
            this.txtboxApellidocliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 24);
            this.label5.TabIndex = 27;
            this.label5.Text = "Dni del cliente";
            // 
            // btnagregarcarrito
            // 
            this.btnagregarcarrito.Location = new System.Drawing.Point(468, 396);
            this.btnagregarcarrito.Name = "btnagregarcarrito";
            this.btnagregarcarrito.Size = new System.Drawing.Size(100, 23);
            this.btnagregarcarrito.TabIndex = 26;
            this.btnagregarcarrito.Text = "Agregar al carrito";
            this.btnagregarcarrito.UseVisualStyleBackColor = true;
            this.btnagregarcarrito.Click += new System.EventHandler(this.btnagregarcarrito_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 33);
            this.label1.TabIndex = 29;
            this.label1.Text = "Facturacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "Categoria del producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "Nombre del producto";
            // 
            // txtboxPrecioproducto
            // 
            this.txtboxPrecioproducto.Location = new System.Drawing.Point(12, 355);
            this.txtboxPrecioproducto.Name = "txtboxPrecioproducto";
            this.txtboxPrecioproducto.Size = new System.Drawing.Size(148, 20);
            this.txtboxPrecioproducto.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 24);
            this.label4.TabIndex = 35;
            this.label4.Text = "Precio del producto";
            // 
            // btnFacturar
            // 
            this.btnFacturar.Location = new System.Drawing.Point(643, 396);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(132, 23);
            this.btnFacturar.TabIndex = 37;
            this.btnFacturar.Text = "Facturar transaccion";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // txtboxCantidadproducto
            // 
            this.txtboxCantidadproducto.Location = new System.Drawing.Point(12, 294);
            this.txtboxCantidadproducto.Name = "txtboxCantidadproducto";
            this.txtboxCantidadproducto.Size = new System.Drawing.Size(148, 20);
            this.txtboxCantidadproducto.TabIndex = 39;
            this.txtboxCantidadproducto.TextChanged += new System.EventHandler(this.txtboxCantidadproducto_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 24);
            this.label6.TabIndex = 38;
            this.label6.Text = "Cantidad del producto";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(12, 166);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 40;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // cmbNombreProducto
            // 
            this.cmbNombreProducto.FormattingEnabled = true;
            this.cmbNombreProducto.Location = new System.Drawing.Point(16, 233);
            this.cmbNombreProducto.Name = "cmbNombreProducto";
            this.cmbNombreProducto.Size = new System.Drawing.Size(121, 21);
            this.cmbNombreProducto.TabIndex = 41;
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.Location = new System.Drawing.Point(441, 25);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.Size = new System.Drawing.Size(500, 350);
            this.dgvCarrito.TabIndex = 43;
            // 
            // cmbDnicliente
            // 
            this.cmbDnicliente.FormattingEnabled = true;
            this.cmbDnicliente.Location = new System.Drawing.Point(12, 100);
            this.cmbDnicliente.Name = "cmbDnicliente";
            this.cmbDnicliente.Size = new System.Drawing.Size(121, 21);
            this.cmbDnicliente.TabIndex = 44;
            this.cmbDnicliente.SelectedIndexChanged += new System.EventHandler(this.cmbDnicliente_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(175, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 24);
            this.label7.TabIndex = 46;
            this.label7.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(317, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 24);
            this.label8.TabIndex = 48;
            this.label8.Text = "Apellido";
            // 
            // txtboxNombrecliente
            // 
            this.txtboxNombrecliente.Location = new System.Drawing.Point(165, 100);
            this.txtboxNombrecliente.Name = "txtboxNombrecliente";
            this.txtboxNombrecliente.Size = new System.Drawing.Size(122, 20);
            this.txtboxNombrecliente.TabIndex = 49;
            // 
            // txtboxApellidocliente
            // 
            this.txtboxApellidocliente.Location = new System.Drawing.Point(308, 101);
            this.txtboxApellidocliente.Name = "txtboxApellidocliente";
            this.txtboxApellidocliente.Size = new System.Drawing.Size(127, 20);
            this.txtboxApellidocliente.TabIndex = 50;
            // 
            // Procesar_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 442);
            this.Controls.Add(this.txtboxApellidocliente);
            this.Controls.Add(this.txtboxNombrecliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbDnicliente);
            this.Controls.Add(this.dgvCarrito);
            this.Controls.Add(this.cmbNombreProducto);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.txtboxCantidadproducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.txtboxPrecioproducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnagregarcarrito);
            this.Name = "Procesar_Compra";
            this.Text = "Procesar_Compra";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnagregarcarrito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxPrecioproducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.TextBox txtboxCantidadproducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbNombreProducto;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.ComboBox cmbDnicliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtboxNombrecliente;
        private System.Windows.Forms.TextBox txtboxApellidocliente;
    }
}