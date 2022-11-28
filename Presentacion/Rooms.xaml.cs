using Entidades;
using System.Windows.Controls;

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para Rooms.xaml
    /// </summary>
    public partial class Rooms : UserControl
    {
        Habitacion habitacion;
        Usuario usuario;
        public Rooms(Habitacion habitacion, Usuario usuario)
        {
            InitializeComponent();
            this.habitacion = habitacion;
            tituloHabitacion.Content = habitacion.Nombre;
            descripcion.Text = habitacion.Descripcion;
            idHabitacion.Content = $"Id: {habitacion.Id}";
            NumHabitacion.Content = $"No. Habitacion: {habitacion.NumHabitacion}";
            tipoHabitacion.Content = $"Tipo: {habitacion.TipoHabitacion}";
            precioHabitacion.Content = $"Precio: {habitacion.Precio}";
            this.usuario = usuario;
        }
        public Rooms() { }

        private void btnReserva_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (usuario.Habitacion==null)
            {
                ConfirmReserva confirm = new ConfirmReserva(habitacion);
                confirm.Usuario = usuario;
                confirm.ShowDialog();
            }
            else
            {
                var mensaje = new MessageBox("Ya tienes una habitacion reservada");
                mensaje.ShowDialog();
            }
        }
    }
}
