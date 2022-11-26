using System.Collections.Generic;

namespace Entidades
{
    public class Administrador : Persona
    {
        public List<Usuario> Usuarios { get; set; }
        public List<Habitacion> Habitaciones { get; set; }

        public Administrador()
        {
            
        }
        public Administrador(string username, string password) : base(username, password)
        {
        }
        public Administrador(uint id, string username, string password, 
            List<Usuario> usuarios, List<Habitacion> habitaciones) : base(id, username, password)
        {
            Usuarios = usuarios;
            Habitaciones = habitaciones;
        }
    }
}