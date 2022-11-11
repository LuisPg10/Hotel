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

        private void botonCrear_MouseClick(object sender, MouseEventArgs e)
        {
            Cambiar.AbrirFormulario<FormRegistrar>();
            limpiar();
        }

        public void limpiar()
        {
            textContraseña.Text = "Contraseña";
            textUsuario.Text = "Usuario";
            
        }
        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textUsuario.Text.Equals("Usuario") || textContraseña.Text.Equals("Contraseña") || textUsuario.Text.Equals("") || textContraseña.Text.Equals(""))
            {
                MessageBox.Show("Complete todas las casillas");
            }else if (Cambiar.ServicioUsuario.validarUsuario(textUsuario.Text,textContraseña.Text)==false)
            {
                MessageBox.Show("Usuario o contraseña incorrectos!");
            }
            else
            {
                Cambiar.AbrirFormulario<FormBienvenida>();
            }
            
        }

        private void FormInicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void textUsuario_Click(object sender, EventArgs e)
        {
            
        }

        private void textContraseña_Click(object sender, EventArgs e)
        {
            
        }

        private void textUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            if (textUsuario.Text.Equals("Usuario"))
            {
                textUsuario.Text = "";
            }
            
            if (textContraseña.Text.Equals(""))
            {
                textContraseña.Text = "Contraseña";
            }
        }

        private void textContraseña_MouseDown(object sender, MouseEventArgs e)
        {
            if (textContraseña.Text.Equals("Contraseña"))
            {
                textContraseña.Text = "";
            }
            
            if (textUsuario.Text.Equals(""))
            {
                textUsuario.Text = "Usuario";
            }
        }
    }
}
