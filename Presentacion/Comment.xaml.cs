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
        public Comment(Habitacion habitacion, Usuario usuario)
        {
            InitializeComponent();
            this.habitacion = habitacion;
            servicioComentario = new ServicioComentario();
            this.usuario = usuario;

            tituloHabitacion.Content = habitacion.Nombre;
            idHabitacion.Content = $"Id: {habitacion.Id}";
            NumHabitacion.Content = $"No. Habitacion: {habitacion.NumHabitacion}";
            tipoHabitacion.Content = $"Tipo: {habitacion.TipoHabitacion}";
            precioHabitacion.Content = $"Precio: {habitacion.Precio}";
        }

        private void btnComment_Click(object sender, RoutedEventArgs e)
        {
            if (textComentario.Text.Equals(string.Empty))
            {
                var mensaje = new MessageBox("Registre su comentario");
                mensaje.Show();
            }
            else
            {
                var comentario = new Comentario(usuario, habitacion, textComentario.Text);
                habitacion.comentarios.Add(comentario);
                servicioComentario.RegistrarComentario(comentario);

                var mensaje = new MessageBox("Comentario registrado");
                mensaje.ShowDialog();
                Close();
            }
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
