using Entidades;
using Logica;
using System;
using System.Windows;

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para ConfirmReserva.xaml
    /// </summary>
    public partial class ConfirmReserva : Window
    {
        public Usuario Usuario { get; set; }
        Habitacion habitacion;
        ServicioUsuario servicioUsuario;
        ServicioHabitacion serviciohabitacion;
        public bool action = false;
        MessageBox mensaje;
        public ConfirmReserva()
        {
            InitializeComponent();

            serviciohabitacion = new ServicioHabitacion();
            servicioUsuario = new ServicioUsuario();

            mensaje = new MessageBox();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            fecha.Text = string.Empty;
            Visibility = Visibility.Collapsed;
            action = false;
        }

        private void Window_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.LeftButton == System.Windows.Input.MouseButtonState.Pressed)
                DragMove();
        }

        private void btnReserva_Click(object sender, RoutedEventArgs e)
        {
            DateTime? date = fecha.SelectedDate;
            if (date!=null)
            {
                Usuario.Habitacion = habitacion;
                habitacion.Usuario = Usuario;
                serviciohabitacion.ActualizarHabitacion(habitacion);
                servicioUsuario.ActualizarUsuario(Usuario);

                fecha.Text = string.Empty;
                mensaje.Text("Reserva exitosa");
                Visibility = Visibility.Collapsed;
                action = true;
            }
            else
            {
                mensaje.Text("Ingrese una fecha valida");
            }
            mensaje.ShowDialog();
        }

        public void setContext(Habitacion habitacion)
        {
            this.habitacion = habitacion;
            tituloHabitacion.Content = habitacion.Nombre;
            idHabitacion.Content = $"Id: {habitacion.Id}";
            NumHabitacion.Content = $"No. Habitacion: {habitacion.NumHabitacion}";
            tipoHabitacion.Content = $"Tipo: {habitacion.TipoHabitacion}";
            precioHabitacion.Content = $"Precio: {habitacion.Precio}";
        }
    }
}
