using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para Comment.xaml
    /// </summary>
    public partial class Comment : Window
    {
        Habitacion habitacion;
        Usuario usuario = new Usuario();
        public Comment(Habitacion habitacion)
        {
            InitializeComponent();
            this.habitacion = habitacion;

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
