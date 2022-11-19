using System;

namespace Entidades
{
    public class Persona
    {
        public uint Id { get; set; }
        public string Nombre { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Persona()
        {
            
        }

        public Persona(uint id, string nombre, string username, string password)
        {
            Id = id;
            Nombre = nombre;
            Username = username;
            Password = password;
        }
    }
}