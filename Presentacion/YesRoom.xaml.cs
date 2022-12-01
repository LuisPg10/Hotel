using Entidades;
using Logica;
using System.Collections.Generic;
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
        Habitacion habitacion;
        ServicioHabitacion servicioHabitacion;
        StackPanel panelPrincipal;
        TwoMessagebox mensaje;
        NotRoom mensaje2;
        Comment comentario;
        List<Rooms> rooms;
        Label titulo;
        Button button;

        public Usuario usuario;
        public YesRoom()
        {
            InitializeComponent();
            servicioUsuario = new ServicioUsuario();
            servicioHabitacion = new ServicioHabitacion();
            comentario = new Comment();

            mensaje = new TwoMessagebox();
            mensaje2 = new NotRoom();

        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            mensaje.setText("¿Seguro desea cancelar la reserva");
            mensaje.ShowDialog();

            if (mensaje.action == true)
            {
                usuario.Habitacion.Usuario = null;
                servicioHabitacion.ActualizarHabitacion(usuario.Habitacion);
                usuario.Habitacion = null;
                servicioUsuario.ActualizarUsuario(usuario);

                var room = new Rooms();
                room.setContext(habitacion, usuario, panelPrincipal, titulo, button, rooms);
                rooms.Insert((int)habitacion.Id - 1, room);

                panelPrincipal.Children.Clear();
                mensaje2.SetText("No has reservado habitación");
                panelPrincipal.Children.Add(mensaje2);
            }
        }
        private void btnComentar_Click(object sender, RoutedEventArgs e)
        {
            comentario.setContext(habitacion, usuario);
            comentario.ShowDialog();
        }
        public void setContext(Habitacion habitacion, Usuario usuario, StackPanel panel, 
            Label titulo, Button button, List<Rooms> rooms)
        {
            panelPrincipal = panel;
            this.habitacion = habitacion;
            this.usuario = usuario;
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
    }
}
