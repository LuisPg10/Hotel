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
    public partial class FormComentarios : Form
    {
        public FormComentarios()
        {
            InitializeComponent();
        }

        private void BotonRegresar_MouseClick(object sender, MouseEventArgs e)
        {
            AbrirFormulario<FormBienvenida>();
        }

        private void botonCerrar_MouseClick(object sender, MouseEventArgs e)
        {
            AbrirFormulario<FormInicioSesion>();
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
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

        private void FormComentarios_Load(object sender, EventArgs e)
        {

        }
    }
}
