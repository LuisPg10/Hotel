using Entidades;
using System.Windows.Controls;

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para YesRoom.xaml
    /// </summary>
    public partial class YesRoom : UserControl
    {
        public YesRoom(Habitacion habitacion)
        {
            InitializeComponent();
            tituloHabitacion.Content = habitacion.Nombre;
            descripcion.Text = habitacion.Descripcion;
            idHabitacion.Content = $"Id: {habitacion.Id}";
            NumHabitacion.Content = $"No. Habitacion: {habitacion.NumHabitacion}";
            tipoHabitacion.Content = $"Tipo: {habitacion.TipoHabitacion}";
            precioHabitacion.Content = $"Precio: {habitacion.Precio}";
        }
        public YesRoom(){ }

        private void cancel_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            
        }
    }
}
