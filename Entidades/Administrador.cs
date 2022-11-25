namespace Entidades
{
    public class Administrador : Persona
    {
        public Administrador()
        {
            
        }

        public Administrador(uint id, string nombre, string correo, string username, string password) : base(id, nombre, correo, username, password)
        {
        }
    }
}