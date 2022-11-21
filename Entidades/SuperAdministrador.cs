namespace Entidades
{
    public class SuperAdministrador : Persona
    {
        public SuperAdministrador()
        {
            
        }
        public SuperAdministrador(uint id, string nombre, string username, string password) : base(id, nombre, username, password)
        {
        }
    }
}