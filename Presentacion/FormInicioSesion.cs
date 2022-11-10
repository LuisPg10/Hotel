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
        FormRegistrar registrar = new FormRegistrar();
        FormBienvenida bienvenida = new FormBienvenida();
        Cambiante cambiar = new Cambiante();
        public FormInicioSesion()
        {
            InitializeComponent();
        }


        private void botonEntrar_MouseClick(object sender, MouseEventArgs e)
        {

        }

        

        private void botonCrear_MouseClick(object sender, MouseEventArgs e)
        {
            Cambiar.AbrirFormulario<FormRegistrar>();
            /*this.Hide();
            registrar.ShowDialog();
            this.Show();*/
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {

            Cambiar.AbrirFormulario<FormBienvenida>();
            /*this.Hide();
            bienvenida.ShowDialog();
            this.Show();*/
        }

        private void FormInicioSesion_Load(object sender, EventArgs e)
        {

        }

        
    }
}
