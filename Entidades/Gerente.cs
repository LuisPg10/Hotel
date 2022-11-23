namespace Entidades
{
    public class Gerente : Persona
    {
        public Gerente()
        {
            
        }

        public Gerente(uint id, string nombre, string correo, string username, string password) : base(id, nombre, correo, username, password)
        {
        }
    }
}