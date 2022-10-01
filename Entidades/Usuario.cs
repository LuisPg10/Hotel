namespace Entidades
{
    public class Usuario : Persona
    {
        public int NumHabitacion { get; set; }
        public Usuario()
        {
            
        }

        public Usuario(int id, string nombre, string username, string password, int numHabitacion) : base(id,nombre,username,password)
        {
            NumHabitacion = numHabitacion;
        }

        
    }
}