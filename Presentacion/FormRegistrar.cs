using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Presentacion
{
    public partial class FormRegistrar : Form
    {
        public FormRegistrar()
        {
            InitializeComponent();
        }

        private void FormRegistrar_Load(object sender, EventArgs e)
        {

        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            if (textUser.Text.Equals("Usuario") || textContraseña.Text.Equals("Contraseña") || textCorreo.Text.Equals("Correo") || textUser.Text.Equals("") || textContraseña.Text.Equals("") || textCorreo.Text.Equals(""))
            {
                MessageBox.Show("Complete todas las casillas");
            }
            else if (Cambiar.ServicioUsuario.validarUsuario(textUser.Text,1) == true)
            {
                MessageBox.Show("Este usuario ya esta registrado!");
            }
            else if (Cambiar.ServicioUsuario.validarUsuario(textUser.Text, 2) == true)
            {
                MessageBox.Show("Este correo ya esta registrado!");
            }
            else
            {
                MessageBox.Show("Usuario Registrado!");
                Usuario user = new Usuario();
                user.Correo = textCorreo.Text;
                user.Username = textUser.Text;
                user.Password = textContraseña.Text;
                Cambiar.ServicioUsuario.registrarUsuario(user);
                Cambiar.AbrirFormulario<FormInicioSesion>();
                limpiar();
            }
            
            
        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            Cambiar.AbrirFormulario<FormInicioSesion>();
            limpiar();
            
        }

        private void textBox3_MouseDown(object sender, MouseEventArgs e)
        {
            if (textCorreo.Text.Equals("Correo"))
            {
                textCorreo.Text = "";
            }

            if (textUser.Text.Equals(""))
            {
                textUser.Text = "Nombre de usuario";
            }

            if (textContraseña.Text.Equals(""))
            {
                textContraseña.Text = "Contraseña";
            }

            
        }

        private void textUser_MouseDown(object sender, MouseEventArgs e)
        {
            if (textUser.Text.Equals("Nombre de usuario"))
            {
                textUser.Text = "";
            }

            if (textContraseña.Text.Equals(""))
            {
                textContraseña.Text = "Contraseña";
            }
            
            if (textCorreo.Text.Equals(""))
            {
                textCorreo.Text = "Correo";
            }
        }

        private void textContraseña_MouseDown(object sender, MouseEventArgs e)
        {
            if (textContraseña.Text.Equals("Contraseña"))
            {
                textContraseña.Text = "";
            }

            if (textUser.Text.Equals(""))
            {
                textUser.Text = "Nombre de usuario";
            }
            if (textCorreo.Text.Equals(""))
            {
                textCorreo.Text = "Correo";
            }
        }

        public void limpiar()
        {
            textUser.Text = "Nombre de usuario";
            textCorreo.Text = "Correo";
            textContraseña.Text = "Contraseña";
            
        }
    }
}
