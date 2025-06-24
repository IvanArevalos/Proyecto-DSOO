namespace FerreteriaLosPalomines
{
    partial class Forminiciopersonal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxPersonal = new System.Windows.Forms.TextBox();
            this.txtboxPcodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPingresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "PERSONAL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(453, 86);
            this.label2.TabIndex = 2;
            this.label2.Text = "Los Polvorines";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(346, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usuario";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtboxPersonal
            // 
            this.txtboxPersonal.Location = new System.Drawing.Point(331, 207);
            this.txtboxPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxPersonal.Name = "txtboxPersonal";
            this.txtboxPersonal.Size = new System.Drawing.Size(103, 20);
            this.txtboxPersonal.TabIndex = 4;
            // 
            // txtboxPcodigo
            // 
            this.txtboxPcodigo.Location = new System.Drawing.Point(331, 271);
            this.txtboxPcodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxPcodigo.Name = "txtboxPcodigo";
            this.txtboxPcodigo.Size = new System.Drawing.Size(103, 20);
            this.txtboxPcodigo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(346, 245);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Codigo";
            // 
            // btnPingresar
            // 
            this.btnPingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPingresar.Location = new System.Drawing.Point(305, 305);
            this.btnPingresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnPingresar.Name = "btnPingresar";
            this.btnPingresar.Size = new System.Drawing.Size(161, 54);
            this.btnPingresar.TabIndex = 7;
            this.btnPingresar.Text = "INGRESAR";
            this.btnPingresar.UseVisualStyleBackColor = true;
            this.btnPingresar.Click += new System.EventHandler(this.btnPingresar_Click_1);
            // 
            // Forminiciopersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 506);
            this.Controls.Add(this.btnPingresar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtboxPcodigo);
            this.Controls.Add(this.txtboxPersonal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Forminiciopersonal";
            this.Text = "Los Palomines Personal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxPersonal;
        private System.Windows.Forms.TextBox txtboxPcodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPingresar;
    }
}