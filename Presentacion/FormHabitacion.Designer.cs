namespace Presentacion
{
    partial class FormHabitacion
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
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botonRegresar = new System.Windows.Forms.Label();
            this.botonCerrar = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelPrincipal.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.White;
            this.panelPrincipal.Controls.Add(this.panel3);
            this.panelPrincipal.Controls.Add(this.flowLayoutPanel1);
            this.panelPrincipal.Controls.Add(this.botonCerrar);
            this.panelPrincipal.Controls.Add(this.botonRegresar);
            this.panelPrincipal.Controls.Add(this.label2);
            this.panelPrincipal.Controls.Add(this.panel2);
            this.panelPrincipal.Location = new System.Drawing.Point(-4, -3);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(748, 483);
            this.panelPrincipal.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 60);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Habitación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(-4, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(829, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "_________________________________________________________________________________" +
    "________________________________________________________";
            // 
            // botonRegresar
            // 
            this.botonRegresar.AutoSize = true;
            this.botonRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRegresar.Location = new System.Drawing.Point(553, 65);
            this.botonRegresar.Name = "botonRegresar";
            this.botonRegresar.Size = new System.Drawing.Size(42, 31);
            this.botonRegresar.TabIndex = 2;
            this.botonRegresar.Text = "←";
            this.botonRegresar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.botonRegresar_MouseClick);
            // 
            // botonCerrar
            // 
            this.botonCerrar.AutoSize = true;
            this.botonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCerrar.Location = new System.Drawing.Point(601, 71);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(141, 25);
            this.botonCerrar.TabIndex = 3;
            this.botonCerrar.Text = "Cerrar sesión";
            this.botonCerrar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label4_MouseClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(26, 121);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(692, 325);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel3.Location = new System.Drawing.Point(3, 456);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(744, 27);
            this.panel3.TabIndex = 6;
            // 
            // FormHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 478);
            this.Controls.Add(this.panelPrincipal);
            this.Name = "FormHabitacion";
            this.Text = "FormHabitacion";
            this.Load += new System.EventHandler(this.FormHabitacion_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label botonCerrar;
        private System.Windows.Forms.Label botonRegresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
    }
}