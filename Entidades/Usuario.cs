namespace Entidades
{
    public class Usuario : Persona
    {
        public string Correo { get; set; }
        public Habitacion Habitacion { get; set; }
        public Usuario()
        {
            
        }


        public Usuario(uint id, string nombre, string username, string password, string correo, Habitacion habitacion) : base(id, nombre, username, password)
        {
            Correo = correo;
            Habitacion = habitacion;
        }
    }
}