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
    public partial class FormInicioSesion : Form
    {
        public FormInicioSesion()
        {
            InitializeComponent();
        }


        private void botonEntrar_MouseClick(object sender, MouseEventArgs e)
        {

        }

        public void AbrirFormulario<MiForm>() where MiForm : Form, new()
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

        private void botonCrear_MouseClick(object sender, MouseEventArgs e)
        {
            AbrirFormulario<FormRegistrar>();
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {

            AbrirFormulario<FormBienvenida>();
        }

        private void FormInicioSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
