﻿namespace FerreteriaLosPalomines
{
    partial class Forminiciocliente
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
            this.txtboxusuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxpassword = new System.Windows.Forms.TextBox();
            this.btningreso = new System.Windows.Forms.Button();
            this.lnklblregistrocliente = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iniciar sesion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // txtboxusuario
            // 
            this.txtboxusuario.Location = new System.Drawing.Point(19, 117);
            this.txtboxusuario.Name = "txtboxusuario";
            this.txtboxusuario.Size = new System.Drawing.Size(148, 20);
            this.txtboxusuario.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contraseña";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtboxpassword
            // 
            this.txtboxpassword.Location = new System.Drawing.Point(19, 201);
            this.txtboxpassword.Name = "txtboxpassword";
            this.txtboxpassword.Size = new System.Drawing.Size(148, 20);
            this.txtboxpassword.TabIndex = 4;
            // 
            // btningreso
            // 
            this.btningreso.Location = new System.Drawing.Point(19, 248);
            this.btningreso.Name = "btningreso";
            this.btningreso.Size = new System.Drawing.Size(75, 23);
            this.btningreso.TabIndex = 5;
            this.btningreso.Text = "Ingresar";
            this.btningreso.UseVisualStyleBackColor = true;
            this.btningreso.Click += new System.EventHandler(this.btningreso_Click);
            // 
            // lnklblregistrocliente
            // 
            this.lnklblregistrocliente.AutoSize = true;
            this.lnklblregistrocliente.Location = new System.Drawing.Point(19, 296);
            this.lnklblregistrocliente.Name = "lnklblregistrocliente";
            this.lnklblregistrocliente.Size = new System.Drawing.Size(160, 13);
            this.lnklblregistrocliente.TabIndex = 6;
            this.lnklblregistrocliente.TabStop = true;
            this.lnklblregistrocliente.Text = "¿No estas registrado? Click Aqui";
            this.lnklblregistrocliente.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblregistrocliente_LinkClicked);
            // 
            // Forminiciocliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 354);
            this.Controls.Add(this.lnklblregistrocliente);
            this.Controls.Add(this.btningreso);
            this.Controls.Add(this.txtboxpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Forminiciocliente";
            this.Text = "Forminiciocliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxusuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxpassword;
        private System.Windows.Forms.Button btningreso;
        private System.Windows.Forms.LinkLabel lnklblregistrocliente;
    }
}