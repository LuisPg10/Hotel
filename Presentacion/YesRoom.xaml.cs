using Entidades;
using Logica;
using System.Windows;
using System.Windows.Controls;

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para YesRoom.xaml
    /// </summary>
    public partial class YesRoom : UserControl
    {
        ServicioUsuario servicioUsuario;
        ServicioHabitacion servicioHabitacion;
        StackPanel panelPrincipal;
        public Usuario Usuario{ get; set; }
        public YesRoom(Habitacion habitacion, StackPanel panel)
        {
            InitializeComponent();
            panelPrincipal = panel;
            servicioUsuario = new ServicioUsuario();
            servicioHabitacion = new ServicioHabitacion();
            tituloHabitacion.Content = habitacion.Nombre;
            descripcion.Text = habitacion.Descripcion;
            idHabitacion.Content = $"Id: {habitacion.Id}";
            NumHabitacion.Content = $"No. Habitacion: {habitacion.NumHabitacion}";
            tipoHabitacion.Content = $"Tipo: {habitacion.TipoHabitacion}";
            precioHabitacion.Content = $"Precio: {habitacion.Precio}";
        }
        public YesRoom(){ }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            var mensaje = new TwoMessagebox("¿Seguro desea cancelar la reserva");
            mensaje.ShowDialog();

            if(mensaje.action == true)
            {
                Usuario.Habitacion.Usuario = null;
                servicioHabitacion.ActualizarHabitacion(Usuario.Habitacion);
                Usuario.Habitacion = null;
                servicioUsuario.ActualizarUsuario(Usuario);

                panelPrincipal.Children.Clear();
                var mensaje2 = new NotRoom("No has reservado habitación");
                panelPrincipal.Children.Add(mensaje2);
            }
        }
    }
}
