using Entidades;
using System.Collections.Generic;

namespace Logica
{
    public class ServicioUsuario
    {
        DatosUsuario datos = new DatosUsuario();

        //Metodo para registrar usuarios a traves de los datos de un objeto de tipo Usuario
        public void RegistrarUsuario(Usuario user)
        {
            datos.RegistrarUsuario(user);
        }

        //Metodo para eliminar usuarios teniendo en cuenta el id
        public void EliminarUsuario(uint id)
        {
            datos.EliminarUsuario(id);
        }

        //Metodo para actualizar los datos de un usuario teniendo en cuenta el id y los datos de un objeto de tipo Usuario
        public void ActualizarUsuario(uint id, Usuario user)
        {
            datos.ActualizarUsuario(id,user);
        }

        //Metodo para consultar un usuario en la base de datos y si existe retorna un objeto de tipo Usuario con sus datos
        public Usuario ConsultarUsuario(uint id)
        {
            return datos.ConsultarUsuario(id);
        }

        //Metodo para verificar la existencia de un UserName en la base de datos
        //Recomendado para el apartado de registrar usuarios
        public bool VerificarUsuario(string username)
        {
            return datos.VerificarUsuario(username);
        }

        //Metodo para verificar la existencia de un correo en la base de datos
        //Recomendado para el apartado de registrar usuarios
        public bool verificarCorreo(String correo)
        {
            return datos.verificarCorreo(correo);
        }

        //Metodo para verificar la existencia del UserName y contraseña en la base de datos
        //Recomendado para el apartado de iniciar sesion
        public bool VerificarEntradaUsuario(string username,string contra)
        {
            
            return datos.VerificarEntradaUsuario(username,contra);
        }

        //Metodo para cargar los datos de la tabla usuario en una lista
        public List<Usuario> ListaUsuarios()
        {
            return datos.ListaUsuarios();
        }

    }
}
