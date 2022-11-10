namespace Presentacion
{
    partial class ventanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.controlVentana = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // controlVentana
            // 
            this.controlVentana.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlVentana.Location = new System.Drawing.Point(0, 0);
            this.controlVentana.Name = "controlVentana";
            this.controlVentana.Size = new System.Drawing.Size(800, 50);
            this.controlVentana.TabIndex = 0;
            this.controlVentana.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlVentana_MouseDown);
            this.controlVentana.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlVentana_MouseMove);
            this.controlVentana.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlVentana_MouseUp);
            // 
            // ventanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.controlVentana);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ventanaPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlVentana;
    }
}

