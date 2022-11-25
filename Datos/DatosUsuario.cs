using System;
using Entidades;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Datos;

namespace Logica
{
    public class DatosUsuario
    {
        Conexion conexion= new Conexion();
        

        //Metodo para registrar usuarios a traves de los datos de un objeto de tipo Usuario
        public void RegistrarUsuario(Usuario user)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand($"INSERT INTO usuario VALUES('{user.Nombre}','{user.Correo}','{user.Username}','{user.Password}')", conexion.ObtenerConexion());
                comando.ExecuteNonQuery();
                Console.WriteLine("Usuario Registrado!");
                conexion.cerrarConexion();
            }catch(Exception ex) { 
                Console.WriteLine("Error al agregar los datos");
            }
        }
        //Metodo para eliminar usuarios teniendo en cuenta el id
        public void EliminarUsuario(uint id)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand($"DELETE FROM usuario WHERE IdUsuario = {id}", conexion.ObtenerConexion());
                comando.ExecuteNonQuery();
                Console.WriteLine("Usuario Eliminado!");
                conexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el usuario");
            }
        }

        //Metodo para actualizar los datos de un usuario teniendo en cuenta el id y los datos de un objeto de tipo Usuario
        public void ActualizarUsuario(uint id, Usuario user)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand($"UPDATE usuario SET Nombre = '{user.Nombre}', Correo = '{user.Correo}', UserName = '{user.Username}', Contraseña = '{user.Password}', IdHabitacion = {user.Habitacion.Id} WHERE IdUsuario = {id}", conexion.ObtenerConexion());
                comando.ExecuteNonQuery();
                Console.WriteLine("Datos actualizados!");
                conexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar los datos");
            }
        }

        //Metodo para consultar un usuario en la base de datos y si existe retorna un objeto de tipo Usuario con sus datos
        public Usuario ConsultarUsuario(uint id)
        {
            Usuario user = new Usuario();
            try
            {
                MySqlCommand comando = new MySqlCommand($"SELECT * FROM usuario WHERE IdUsuario = '{id}'", conexion.ObtenerConexion());
                MySqlDataReader consulta = comando.ExecuteReader();
                while (consulta.Read())
                {
                    if (consulta.GetUInt32(0) == id)
                    {
                        user.Id = consulta.GetUInt32(0);
                        user.Nombre = consulta.GetString(1);
                        user.Correo = consulta.GetString(2);
                        user.Username = consulta.GetString(3);
                        user.Password = consulta.GetString(4);
                        user.Habitacion = new DatosHabitacion().ConsultarHabitacion(consulta.GetUInt32(5));

                    }
                    else
                    {
                        user = null;
                    }
                }
                conexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al consultar el usuario");
            }
            return user;
        }

        //Metodo para verificar la existencia de un UserName en la base de datos
        //Recomendado para el apartado de registrar usuarios
        public bool VerificarUsuario(string username)
        {
            bool resultado = false;
            try
            {
                MySqlCommand comando = new MySqlCommand($"SELECT * FROM usuario WHERE UserName = '{username}'", conexion.ObtenerConexion());
                MySqlDataReader consulta = comando.ExecuteReader();
                while(consulta.Read())
                {
                    if(consulta.GetString(3).Equals(username))
                    {
                        resultado = true;
                    }               
                }
                conexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al consultar el usuario");
            }
            return resultado;
        }

        //Metodo para verificar la existencia de un correo en la base de datos
        //Recomendado para el apartado de registrar usuarios
        public bool verificarCorreo(string correo)
        {
            bool resultado = false;
            try
            {
                MySqlCommand comando = new MySqlCommand($"SELECT * FROM usuario WHERE Correo = '{correo}'", conexion.ObtenerConexion());
                MySqlDataReader consulta = comando.ExecuteReader();
                while (consulta.Read())
                {
                    if (consulta.GetString(2).Equals(correo))
                    {
                        resultado = true;
                    }
                }
                conexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al verificar el correo");
            }
            return resultado;
        }

        //Metodo para verificar la existencia del UserName y contraseña en la base de datos
        //Recomendado para el apartado de iniciar sesion
        public bool VerificarEntradaUsuario(string username,string contra)
        {
            bool resultado = false;
            try
            {
                MySqlCommand comando = new MySqlCommand($"SELECT * FROM usuario WHERE UserName = '{username}' AND Contraseña = '{contra}'", conexion.ObtenerConexion());
                MySqlDataReader consulta = comando.ExecuteReader();
                while (consulta.Read())
                {
                    if (consulta.GetString(3).Equals(username) && consulta.GetString(4).Equals(contra))
                    {
                        resultado = true;
                    }
                }
                conexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al consultar el usuario");
            }
            return resultado;
        }

        //Metodo para cargar los datos de la tabla usuario en una lista
        public List<Usuario> ListaUsuarios()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            try
            {
                MySqlCommand comando = new MySqlCommand($"SELECT * FROM usuario", conexion.ObtenerConexion());
                MySqlDataReader consulta = comando.ExecuteReader();
                while (consulta.Read())
                {
                    Usuario user = new Usuario();
                    user.Id = consulta.GetUInt32(0);
                    user.Nombre = consulta.GetString(1);
                    user.Correo = consulta.GetString(2);
                    user.Username = consulta.GetString(3);
                    user.Password = consulta.GetString(4);
                    user.Habitacion = new DatosHabitacion().ConsultarHabitacion(consulta.GetUInt32(5));
                    listaUsuarios.Add(user);    
                }
                conexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al consultar el usuario");
            }

            return listaUsuarios;
        }

    }
}
