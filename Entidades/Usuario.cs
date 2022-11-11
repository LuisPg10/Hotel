namespace Entidades
{
    public class Usuario : Persona
    {
        public int NumHabitacion { get; set; }
        public Usuario()
        {
            
        }

        public Usuario(int id, string nombre, string correo, string username, string password) : base(id, nombre, correo, username, password)
        {
        }
    }
}