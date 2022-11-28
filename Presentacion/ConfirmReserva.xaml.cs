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
        public ConfirmReserva(Habitacion habitacion)
        {
            InitializeComponent();
            this.habitacion = habitacion;
            serviciohabitacion = new ServicioHabitacion();
            servicioUsuario = new ServicioUsuario();
            tituloHabitacion.Content = habitacion.Nombre;
            idHabitacion.Content = $"Id: {habitacion.Id}";
            NumHabitacion.Content = $"No. Habitacion: {habitacion.NumHabitacion}";
            tipoHabitacion.Content = $"Tipo: {habitacion.TipoHabitacion}";
            precioHabitacion.Content = $"Precio: {habitacion.Precio}";
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
            action = false;
        }
        public ConfirmReserva(){ }

        private void Window_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.LeftButton == System.Windows.Input.MouseButtonState.Pressed)
                DragMove();
        }

        private void btnReserva_Click(object sender, RoutedEventArgs e)
        {
            DateTime? date = fecha.SelectedDate;
            MessageBox mensaje;

            if (date!=null)
            {
                Usuario.Habitacion = habitacion;
                habitacion.Usuario = Usuario;
                serviciohabitacion.ActualizarHabitacion(habitacion);
                servicioUsuario.ActualizarUsuario(Usuario);
                mensaje = new MessageBox("Reserva exitosa");
                Close();
                action = true;
            }
            else
            {
                mensaje = new MessageBox("Ingrese una fecha valida");
            }
            mensaje.ShowDialog();
        }
    }
}
