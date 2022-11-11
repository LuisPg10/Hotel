namespace Presentacion
{
    partial class FormInicioSesion
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
            this.botonCrear = new System.Windows.Forms.Label();
            this.botonEntrar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textContraseña = new System.Windows.Forms.TextBox();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPrincipal.SuspendLayout();
            this.botonEntrar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.White;
            this.panelPrincipal.Controls.Add(this.botonCrear);
            this.panelPrincipal.Controls.Add(this.botonEntrar);
            this.panelPrincipal.Controls.Add(this.textContraseña);
            this.panelPrincipal.Controls.Add(this.textUsuario);
            this.panelPrincipal.Controls.Add(this.panel2);
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(748, 483);
            this.panelPrincipal.TabIndex = 0;
            // 
            // botonCrear
            // 
            this.botonCrear.AutoSize = true;
            this.botonCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCrear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.botonCrear.Location = new System.Drawing.Point(321, 400);
            this.botonCrear.Name = "botonCrear";
            this.botonCrear.Size = new System.Drawing.Size(68, 13);
            this.botonCrear.TabIndex = 4;
            this.botonCrear.Text = "Crear cuenta";
            this.botonCrear.MouseClick += new System.Windows.Forms.MouseEventHandler(this.botonCrear_MouseClick);
            // 
            // botonEntrar
            // 
            this.botonEntrar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.botonEntrar.Controls.Add(this.label2);
            this.botonEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonEntrar.Location = new System.Drawing.Point(292, 322);
            this.botonEntrar.Name = "botonEntrar";
            this.botonEntrar.Size = new System.Drawing.Size(126, 51);
            this.botonEntrar.TabIndex = 3;
            this.botonEntrar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label2_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Entrar";
            this.label2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label2_MouseClick);
            // 
            // textContraseña
            // 
            this.textContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textContraseña.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textContraseña.Location = new System.Drawing.Point(232, 249);
            this.textContraseña.Name = "textContraseña";
            this.textContraseña.Size = new System.Drawing.Size(259, 35);
            this.textContraseña.TabIndex = 2;
            this.textContraseña.Text = "Contraseña";
            this.textContraseña.Click += new System.EventHandler(this.textContraseña_Click);
            this.textContraseña.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textContraseña_MouseDown);
            // 
            // textUsuario
            // 
            this.textUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsuario.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textUsuario.Location = new System.Drawing.Point(233, 181);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(259, 35);
            this.textUsuario.TabIndex = 1;
            this.textUsuario.Text = "Usuario";
            this.textUsuario.Click += new System.EventHandler(this.textUsuario_Click);
            this.textUsuario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textUsuario_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(233, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 76);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iniciar sesión";
            // 
            // FormInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 478);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FromInicioSesion";
            this.Load += new System.EventHandler(this.FormInicioSesion_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.botonEntrar.ResumeLayout(false);
            this.botonEntrar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel botonEntrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textContraseña;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label botonCrear;
    }
}