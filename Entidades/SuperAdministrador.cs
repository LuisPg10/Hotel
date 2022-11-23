namespace Entidades
{
    public class SuperAdministrador : Persona
    {
        public SuperAdministrador()
        {
            
        }

        public SuperAdministrador(uint id, string nombre, string correo, string username, string password) : base(id, nombre, correo, username, password)
        {
        }
    }
}