namespace FerreteriaLosPalomines
{
    partial class InicioPersonal
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
            this.menuPersonal1 = new FerreteriaLosPalomines.MenuPersonal();
            this.SuspendLayout();
            // 
            // menuPersonal1
            // 
            this.menuPersonal1.Location = new System.Drawing.Point(3, 3);
            this.menuPersonal1.Name = "menuPersonal1";
            this.menuPersonal1.Size = new System.Drawing.Size(1146, 28);
            this.menuPersonal1.TabIndex = 4;
            // 
            // InicioPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 673);
            this.Controls.Add(this.menuPersonal1);
            this.IsMdiContainer = true;
            this.Name = "InicioPersonal";
            this.Text = "InicioPersonal";
            this.ResumeLayout(false);

        }

        #endregion

        private MenuPersonal menuPersonal1;
    }
}