using System;
using System.Globalization;

namespace Entidades
{
    public class Administrador : Persona
    {
        public Administrador()
        {
            
        }
        public Administrador(uint id, string nombre, string username, string password) : base(id, nombre, username, password)
        {
        }
    }
}