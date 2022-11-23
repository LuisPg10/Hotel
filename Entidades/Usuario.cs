namespace Entidades
{
    public class Usuario : Persona
    {

        public Habitacion Habitacion { get; set; }
        public Usuario()
        {
            
        }

        public Usuario(uint id, string nombre, string correo, string username, string password, Habitacion habitacion) : base(id, nombre, correo, username, password)
        {
            Habitacion= habitacion;
        }
    }
}