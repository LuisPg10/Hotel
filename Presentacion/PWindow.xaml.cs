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
        ServicioHabitacion servicioHabitacion;
        Usuario usuario;

        public PWindow(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            servicioHabitacion = new ServicioHabitacion();
            CargarHabitaciones();
        }
        public PWindow() { }
        
        //Metodo para controlar la vista despues del ingreso
        private void btnRoom_Back_Click(object sender, RoutedEventArgs e)
        {
            if (labelTitulo.Content.Equals($" Bienvenido {usuario.Nombre} "))
            {
                labelTitulo.Content = " Habitación ";
                btnRoom_Back.Content = "←";

                if (usuario.Habitacion == null)
                {
                    contenedorPersonal.Children.Clear();
                    var habitaciuon = new NotRoom("No has reservado habitación");
                    contenedorPersonal.Children.Add(habitaciuon);
                }
                else
                {
                    contenedorPersonal.Children.Clear();
                    var habitacion = new YesRoom(usuario.Habitacion, contenedorPersonal);
                    habitacion.Usuario = usuario;
                    contenedorPersonal.Children.Add(habitacion);
                }
            }
            else
            {
                labelTitulo.Content = $" Bienvenido {usuario.Nombre} ";
                btnRoom_Back.Content = "Habitacion reservada";
                CargarHabitaciones();
            }
        }

        //Metodo para el cargue de las habitaciones en el programa
        private void CargarHabitaciones()
        {
            contenedorPersonal.Children.Clear();
            foreach (var habitacion in servicioHabitacion.ListaHabitaciones())
            {
                if (habitacion.Usuario == null)
                {
                    var room = new Rooms(habitacion, usuario, contenedorPersonal, labelTitulo, btnRoom_Back);
                    contenedorPersonal.Children.Add(room);
                }
            }
        }
    }
}
