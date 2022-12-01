using Entidades;
using Logica;
using System.Collections.Generic;
using System.Windows;
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
        MessageBox mensaje;
        NotRoom mensaje2;
        ConfirmReserva confirm;
        List<Comentario> comentarios;
        List<Rooms> rooms;
        public static List<CommentUser> controlesComentarios;

        #endregion
        public Rooms()
        {
            InitializeComponent();
            var window = Window.GetWindow(this);
            mensaje = new MessageBox();
            mensaje.Owner = window;
            mensaje2 = new NotRoom();
            confirm = new ConfirmReserva();
            confirm.Owner = window;
            comentarios = new List<Comentario>();
            servicioComentario = new ServicioComentario();
            controlesComentarios = new List<CommentUser>();

            comentarios = servicioComentario.ListaComentarios();
            CargarComentarios();
        }

        #region Eventos de esta clase
        //Evento del boton para la reserva de la habitacion
        private void btnReserva_Click(object sender, RoutedEventArgs e)
        {
            if (usuario.Habitacion == null)
            {
                confirm.Usuario = usuario;
                confirm.setContext(habitacion);
                confirm.ShowDialog();

                if (confirm.action == true)
                {
                    contenedor.Children.Remove(this);
                    rooms.Remove(this);
                }
            }
            else
            {
                mensaje.Text("Ya tienes una habitacion reservada");
                mensaje.ShowDialog();
            }
        }

        //Evento para mostrar los comentarios
        private void btnComentrarios_Click(object sender, RoutedEventArgs e)
        {
            titulo.Content = " Comentarios ";
            button.Content = "←";

            contenedor.Children.Clear();
            ListarComentarios();

            if (contenedor.Children.Count == 0)
            {
                mensaje2.SetText("Sin comentarios en esta habitacion");
                contenedor.Children.Add(mensaje2);
            }
        }
        public void setContext(Habitacion habitacion, Usuario usuario,
            StackPanel contenedor, Label titulo, Button button, List<Rooms> rooms)
        {
            this.habitacion = habitacion;
            this.usuario = usuario;
            this.contenedor = contenedor;
            this.titulo = titulo;
            this.button = button;
            this.rooms = rooms;

            tituloHabitacion.Content = habitacion.Nombre;
            descripcion.Text = habitacion.Descripcion;
            idHabitacion.Content = $"Id: {habitacion.Id}";
            NumHabitacion.Content = $"No. Habitacion: {habitacion.NumHabitacion}";
            tipoHabitacion.Content = $"Tipo: {habitacion.TipoHabitacion}";
            precioHabitacion.Content = $"Precio: {habitacion.Precio}";
        }
        #endregion

        private void CargarComentarios()
        {
            foreach (var comentario in comentarios)
            {
                var comentarioUsuario = new CommentUser(comentario);
                controlesComentarios.Add(comentarioUsuario);
            }
        }

        private void ListarComentarios()
        {
            foreach (var comentario in controlesComentarios)
            {
                if (comentario.id == habitacion.Id)
                {
                    contenedor.Children.Add(comentario);
                }
            }
        }
    }
}
