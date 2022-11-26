namespace Entidades
{
    public class Comentario
    {
        public uint Id { get; set; }
        public Usuario Usuario { get; set; }
        public Habitacion Habitacion { get; set; }
        public string Comentarios { get; set; }

        public Comentario(){}
        public Comentario(Usuario usuario, Habitacion habitacion, string comentarios)
        {
            Usuario = usuario;
            Habitacion = habitacion;
            Comentarios = comentarios;
        }
        public Comentario(uint id, Usuario usuario, Habitacion habitacion, string comentarios)
        {
            Id = id;
            Usuario = usuario;
            Habitacion = habitacion;
            Comentarios = comentarios;
        }
    }
}
