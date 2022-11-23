using System;

namespace Entidades
{
    public class Persona
    {
        public uint Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Persona()
        {
            
        }

        public Persona(uint id, string nombre, string correo, string username, string password)
        {
            Id = id;
            Nombre = nombre;
            Correo = correo;
            Username = username;
            Password = password;
        }
    }
}