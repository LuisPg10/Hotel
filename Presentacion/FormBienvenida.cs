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
    public partial class FormBienvenida : Form
    {
        
        public FormBienvenida()
        {
            InitializeComponent();
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void botonHabitacion_MouseClick(object sender, MouseEventArgs e)
        {
            AbrirFormulario<FormHabitacion>();
        }

        private void botonCerrar_MouseClick(object sender, MouseEventArgs e)
        {
            AbrirFormulario<FormInicioSesion>();
        }

        private void botonHabitacion_Click(object sender, EventArgs e)
        {

        }

        private void FormBienvenida_Load(object sender, EventArgs e)
        {

        }
        
    }
}
