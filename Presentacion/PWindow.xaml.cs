using Entidades;
using Logica;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para PWindow.xaml
    /// </summary>
    public partial class PWindow : UserControl
    {
        string mensaje;
        List<Habitacion> habitaciones;
        Usuario usuario;
        public PWindow(Usuario usuario, List<Habitacion> habitaciones)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.habitaciones = habitaciones;
            CargarHabitaciones();
            mensaje = "No has reservado habitación";
        }

        private void btnRoom_Back_Click(object sender, RoutedEventArgs e)
        {
            if (mensaje.Equals(mensaje = "No has reservado habitación"))
            {
                contenedorPersonal.Children.Clear();
                NotRoom habitaciuon = new NotRoom(mensaje);
                contenedorPersonal.Children.Add(habitaciuon);
                mensaje = string.Empty;
            }
            else
            {
                CargarHabitaciones();
                mensaje = "No has reservado habitación";
            }
        }

        private void CargarHabitaciones()
        {
            contenedorPersonal.Children.Clear();
            foreach (var habitacion in habitaciones)
            {
                var room = new Rooms();
                contenedorPersonal.Children.Add(room);
            }
        }
    }
}
