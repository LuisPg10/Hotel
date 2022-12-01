using Entidades;
using Logica;
using System.Windows;
using System.Windows.Input;

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para Comment.xaml
    /// </summary>
    public partial class Comment : Window
    {
        Habitacion habitacion;
        Usuario usuario = new Usuario();
        ServicioComentario servicioComentario;
        MessageBox mensaje;
        public Comment()
        {
            InitializeComponent();

            servicioComentario = new ServicioComentario();
            mensaje = new MessageBox();
        }

        private void btnComment_Click(object sender, RoutedEventArgs e)
        {
            if (textComentario.Text.Equals(string.Empty))
            {
                mensaje.Text("Registre su comentario");
                mensaje.ShowDialog();
            }
            else
            {
                var comentario = new Comentario(usuario, habitacion, textComentario.Text);
                habitacion.comentarios.Add(comentario);
                servicioComentario.RegistrarComentario(comentario);

                var comment = new CommentUser(comentario);
                Rooms.controlesComentarios.Add(comment);
                textComentario.Text = string.Empty;

                mensaje.Text("Comentario registrado");
                mensaje.ShowDialog();
                Visibility = Visibility.Collapsed;
            }
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            textComentario.Text = string.Empty;
            Visibility = Visibility.Collapsed;
        }

        public void setContext(Habitacion habitacion, Usuario usuario)
        {
            this.habitacion = habitacion;
            this.usuario = usuario;

            tituloHabitacion.Content = habitacion.Nombre;
            idHabitacion.Content = $"Id: {habitacion.Id}";
            NumHabitacion.Content = $"No. Habitacion: {habitacion.NumHabitacion}";
            tipoHabitacion.Content = $"Tipo: {habitacion.TipoHabitacion}";
            precioHabitacion.Content = $"Precio: {habitacion.Precio}";
        }
    }
}
