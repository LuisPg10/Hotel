namespace Entidades
{
    public class Usuario : Persona
    {
        public string Correo{ get; set; }
        public string Nombre{ get; set; }
        public Habitacion Habitacion { get; set; }
        public Usuario()
        {
            
        }

        public Usuario(string nombre, string correo, string username, string password) : base(username, password)
        {
            Nombre = nombre;
            Correo = correo;
        }

        public Usuario(uint id, string nombre, string correo, string username, string password) : base(id,username, password)
        {
            Nombre = nombre;
            Correo = correo;
        }
    }
}