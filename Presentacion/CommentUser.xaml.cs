using Entidades;
using Logica;
using System.Windows.Controls;

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para CommentUser.xaml
    /// </summary>
    public partial class CommentUser : UserControl
    {
        public uint id;
        public CommentUser(Comentario comentario)
        {
            InitializeComponent();
            userName.Content = comentario.Usuario.Nombre;
            commentUser.Text = comentario.Comentarios;
            textId.Content = $"Id: {comentario.Habitacion.Id}";
            id = comentario.Habitacion.Id;
            numHabitacion.Content = $"No.Habitación: {comentario.Habitacion.NumHabitacion}";
            tipoHabitacion.Content = $"Tipo: {comentario.Habitacion.TipoHabitacion}";
        }

    }
}
