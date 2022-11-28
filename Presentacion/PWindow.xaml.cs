using Entidades;
using Logica;
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
        ServicioHabitacion servicioHabitacion;
        Usuario usuario;
        public PWindow(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            servicioHabitacion = new ServicioHabitacion();
            CargarHabitaciones();
            mensaje = "No has reservado habitación";
        }
        public PWindow() { }

        private void btnRoom_Back_Click(object sender, RoutedEventArgs e)
        {
            if (mensaje.Equals("No has reservado habitación"))
            {
                if (usuario.Habitacion == null)
                {
                    contenedorPersonal.Children.Clear();
                    var habitaciuon = new NotRoom(mensaje);
                    contenedorPersonal.Children.Add(habitaciuon);
                }
                else
                {
                    contenedorPersonal.Children.Clear();
                    var habitacion = new YesRoom(usuario.Habitacion, contenedorPersonal);
                    habitacion.Usuario = usuario;
                    contenedorPersonal.Children.Add(habitacion);
                }
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
            foreach (var habitacion in servicioHabitacion.ListaHabitaciones())
            {
                if (habitacion.Usuario == null)
                {
                    var room = new Rooms(habitacion, usuario, contenedorPersonal);
                    contenedorPersonal.Children.Add(room);
                }
            }
        }
    }
}
