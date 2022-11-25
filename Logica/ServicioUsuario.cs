using System;
using Entidades;
using System.Collections;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Datos;
using System.Diagnostics.Contracts;

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
        public void EliminarUsuario(int id)
        {
            datos.EliminarUsuario(id);
        }

        //Metodo para actualizar los datos de un usuario teniendo en cuenta el id y los datos de un objeto de tipo Usuario
        public void ActualizarUsuario(int id, Usuario user)
        {
            datos.ActualizarUsuario(id,user);
        }

        //Metodo para consultar un usuario en la base de datos y si existe retorna un objeto de tipo Usuario con sus datos
        public Usuario consultarUsuario(int id)
        {
            return datos.consultarUsuario(id);
        }

        //Metodo para verificar la existencia de un UserName en la base de datos
        //Recomendado para el apartado de registrar usuarios
        public bool verificarUsuario(String username)
        {
            
            return datos.verificarUsuario(username);
        }

        //Metodo para verificar la existencia de un correo en la base de datos
        //Recomendado para el apartado de registrar usuarios
        public bool verificarCorreo(String correo)
        {
            return datos.verificarCorreo(correo);
        }

        //Metodo para verificar la existencia del UserName y contraseña en la base de datos
        //Recomendado para el apartado de iniciar sesion
        public bool verificarEntradaUsuario(String username,String contra)
        {
            
            return datos.verificarEntradaUsuario(username,contra);
        }

        //Metodo para cargar los datos de la tabla usuario en una lista
        public List<Usuario> listaUsuarios()
        {
            return datos.listaUsuarios();
        }

    }
}
