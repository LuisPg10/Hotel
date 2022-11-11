using System;
using System.Globalization;

namespace Entidades
{
    public class Administrador : Persona
    {
        public Administrador()
        {
            
        }

        public Administrador(int id, string nombre, string correo, string username, string password) : base(id, nombre, correo, username, password)
        {
        }
    }
}