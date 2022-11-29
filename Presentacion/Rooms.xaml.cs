using Entidades;
using Logica;
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
        StackPanel contenedor;
        ServicioComentario servicioComentario;

        public Rooms(Habitacion habitacion, Usuario usuario, StackPanel contendor)
        {
            InitializeComponent();
            this.habitacion = habitacion;
            servicioComentario = new ServicioComentario();

            tituloHabitacion.Content = habitacion.Nombre;
            descripcion.Text = habitacion.Descripcion;
            idHabitacion.Content = $"Id: {habitacion.Id}";
            NumHabitacion.Content = $"No. Habitacion: {habitacion.NumHabitacion}";
            tipoHabitacion.Content = $"Tipo: {habitacion.TipoHabitacion}";
            precioHabitacion.Content = $"Precio: {habitacion.Precio}";
            this.usuario = usuario;
            this.contenedor = contendor;
        }
        public Rooms() { }

        private void btnReserva_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (usuario.Habitacion==null)
            {
                ConfirmReserva confirm = new ConfirmReserva(habitacion);
                confirm.Usuario = usuario;
                confirm.ShowDialog();

                if (confirm.action == true)
                    contenedor.Children.Remove(this);
            }
            else
            {
                var mensaje = new MessageBox("Ya tienes una habitacion reservada");
                mensaje.ShowDialog();
            }
        }

        private void btnComentrarios_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            contenedor.Children.Clear();
            foreach (var comentario in servicioComentario.ListaComentarios())
            {
                if (comentario.Habitacion.Id == habitacion.Id)
                {
                    var comentarioUsuario = new CommentUser(comentario);
                    contenedor.Children.Add(comentarioUsuario);
                }
            }
        }

    }
}
