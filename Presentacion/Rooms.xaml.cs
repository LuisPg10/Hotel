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
        #region variables para Room

        Habitacion habitacion;
        Usuario usuario;
        StackPanel contenedor;
        ServicioComentario servicioComentario;
        Label titulo;
        Button button;

        #endregion

        public Rooms(Habitacion habitacion, Usuario usuario, 
            StackPanel contenedor, Label titulo, Button button)
        {
            InitializeComponent();
            this.habitacion = habitacion;
            servicioComentario = new ServicioComentario();
            this.usuario = usuario;
            this.contenedor = contenedor;
            this.titulo = titulo;
            this.button = button;

            tituloHabitacion.Content = habitacion.Nombre;
            descripcion.Text = habitacion.Descripcion;
            idHabitacion.Content = $"Id: {habitacion.Id}";
            NumHabitacion.Content = $"No. Habitacion: {habitacion.NumHabitacion}";
            tipoHabitacion.Content = $"Tipo: {habitacion.TipoHabitacion}";
            precioHabitacion.Content = $"Precio: {habitacion.Precio}";
        }
        public Rooms() { }

        #region Eventos de esta clase
        //Evento del boton para la reserva de la habitacion
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

        //Evento para mostrar los comentarios
        private void btnComentrarios_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            titulo.Content = " Comentarios ";
            button.Content = "←";

            contenedor.Children.Clear();
            foreach (var comentario in servicioComentario.ListaComentarios())
            {
                if (comentario.Habitacion.Id == habitacion.Id)
                {
                    var comentarioUsuario = new CommentUser(comentario);
                    contenedor.Children.Add(comentarioUsuario);
                }
            }

            if (contenedor.Children.Count == 0)
            {
                NotRoom mensaje = new NotRoom("Sin comentarios en esta habitacion");
                contenedor.Children.Add(mensaje);
            }
        }
        #endregion
    }
}
