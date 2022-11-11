using System;
using Entidades;
using System.Collections;
using System.Collections.Generic;

namespace Logica
{
    public class ServicioUsuario
    {
        List<Usuario> listaUsuarios = new List<Usuario>();
        
        public void registrarUsuario(Usuario user)
        {
            listaUsuarios.Add(user);
        }

        public bool validarUsuario(string user, string pass)
        {
            bool validar = false;

            foreach (Usuario usuario in listaUsuarios)
            {
                if (usuario.Username.Equals(user) && usuario.Password.Equals(pass))
                {
                    validar = true;
                }
            }

            return validar;
        }

        public bool validarUsuario(string dato,int op)
        {
            bool validar = false;

            foreach (Usuario usuario in listaUsuarios)
            {
                switch (op)
                {
                    case 1:
                        if (usuario.Username.Equals(dato))
                        {
                            validar = true;
                        }
                        break;
                    case 2:
                        if (usuario.Correo.Equals(dato))
                        {
                            validar = true;
                        }
                        break;
                }
                
            }

            return validar;
        }


    }
}
