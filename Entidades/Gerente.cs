using System.Collections.Generic;

namespace Entidades
{
    public class Gerente : Persona
    {
        public List<Administrador> Administradores { get; set; }
        public Gerente(){}
        public Gerente(string username, string password) : base(username, password)
        {
        }
        public Gerente(uint id, string username, 
            string password, List<Administrador> administradores) : base(id, username, password)
        {
            Administradores = administradores;
        }
    }
}