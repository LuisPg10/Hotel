using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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
        ServicioUsuario servicio = new ServicioUsuario();
        FormReservar reservar;
        public FormBienvenida()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void botonHabitacion_MouseClick(object sender, MouseEventArgs e)
        {
            Cambiar.AbrirFormulario<FormHabitacion>();
        }

        private void botonCerrar_MouseClick(object sender, MouseEventArgs e)
        {
            Cambiar.AbrirFormulario<FormInicioSesion>();
        }

        private void botonHabitacion_Click(object sender, EventArgs e)
        {

        }

        private void FormBienvenida_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            if (reservar == null)
            {
                reservar = new FormReservar();
            }
            if (!reservar.reservada)
            {
                reservar.ShowDialog(this);

                if (reservar.reservada)
                {
                    Habitacion habitacion = new Habitacion();
                    servicio.ReservarHabitacion(habitacion);
                }
            }
            else
            {
                MessageBox.Show("Ya reservo su habitacion");
            }
        }
    }
}
