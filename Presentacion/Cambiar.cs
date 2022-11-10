using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Cambiar : Form
    {
        public static Panel panelPrincipal;
        public static int numero = 0;
        public Cambiar()
        {
            InitializeComponent();
            panelPrincipal = new System.Windows.Forms.Panel();
            panelPrincipal.BackColor = System.Drawing.Color.Black;
            panelPrincipal.Location = new System.Drawing.Point(-2, -2);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new System.Drawing.Size(748, 483);
            panelPrincipal.TabIndex = 1;

            this.Controls.Add(panelPrincipal);
            AbrirFormulario<FormInicioSesion>();
        }

        public static int numeros()
        {
            return 0;
        }
        private void Cambiar_Load(object sender, EventArgs e)
        {

        }

        public static void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;

            formulario = panelPrincipal.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
                                                                                           //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelPrincipal.Controls.Add(formulario);
                panelPrincipal.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }
    }
}
