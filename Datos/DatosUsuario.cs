using System;
using Entidades;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class DatosUsuario
    {
        Conexion conexion= new Conexion();
        
        //Metodo para registrar usuarios a traves de los datos de un objeto de tipo Usuario
        public void RegistrarUsuario(Usuario user)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand($"INSERT INTO usuarios VALUES({0},'{user.Nombre}','{user.Correo}','{user.Username}','{user.Password}','NULL')", conexion.ObtenerConexion());
                comando.ExecuteNonQuery();
                Console.WriteLine("Usuario Registrado!");
                conexion.cerrarConexion();
            }catch(Exception) { 
                Console.WriteLine("Error al agregar los datos");
            }
        }
        //Metodo para eliminar usuarios teniendo en cuenta el id
        public void EliminarUsuario(uint id)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand($"DELETE FROM usuarios WHERE IdUsuario = {id}", conexion.ObtenerConexion());
                comando.ExecuteNonQuery();
                Console.WriteLine("Usuario Eliminado!");
                conexion.cerrarConexion();
            }
            catch (Exception)
            {
                Console.WriteLine("Error al eliminar el Usuario");
            }
        }

        //Metodo para actualizar los datos de un Usuario teniendo en cuenta el id y los datos de un objeto de tipo Usuario
        public void ActualizarUsuario(uint id, Usuario user)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand($"UPDATE usuarios SET Nombre = '{user.Nombre}', Correo = '{user.Correo}', UserName = '{user.Username}', Pssword = '{user.Password}', IdHabitacion = {user.Habitacion.Id} WHERE IdUsuario = {id}", conexion.ObtenerConexion());
                comando.ExecuteNonQuery();
                Console.WriteLine("Datos actualizados!");
                conexion.cerrarConexion();
            }
            catch (Exception)
            {
                Console.WriteLine("Error al actualizar los datos");
            }
        }

        //Metodo para consultar un Usuario en la base de datos y si existe retorna un objeto de tipo Usuario con sus datos
        public Usuario ConsultarUsuario(string username)
        {
            Usuario user = new Usuario();
            try
            {
                MySqlCommand comando = new MySqlCommand($"SELECT * FROM usuarios WHERE UserName = '{username}'", conexion.ObtenerConexion());
                MySqlDataReader consulta = comando.ExecuteReader();
                while (consulta.Read())
                {
                    if (consulta.GetString(3) == username)
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
            catch (Exception)
            {
                Console.WriteLine("Error al consultar el Usuario");
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
                MySqlCommand comando = new MySqlCommand($"SELECT * FROM usuarios WHERE UserName = '{username}'", conexion.ObtenerConexion());
                MySqlDataReader consulta = comando.ExecuteReader();
                while(consulta.Read())
                {
                    if(consulta.GetString(3).Equals(username))
                    {
                        resultado = true;
                    }               
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error al consultar el Usuario");
            }
            return resultado;
        }

        //Metodo para verificar la existencia de un correo en la base de datos
        //Recomendado para el apartado de registrar usuarios
        public bool VerificarCorreo(string correo)
        {
            bool resultado = false;
            try
            {
                MySqlCommand comando = new MySqlCommand($"SELECT * FROM usuarios WHERE Correo = '{correo}'", conexion.ObtenerConexion());
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
            catch (Exception)
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
                MySqlCommand comando = new MySqlCommand($"SELECT * FROM usuarios WHERE UserName = '{username}' AND Pssword = '{contra}'", conexion.ObtenerConexion());
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
            catch (Exception)
            {
                Console.WriteLine("Error al consultar el Usuario");
            }
            return resultado;
        }

        //Metodo para cargar los datos de la tabla Usuario en una lista
        public List<Usuario> ListaUsuarios()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            try
            {
                MySqlCommand comando = new MySqlCommand($"SELECT * FROM usuarios", conexion.ObtenerConexion());
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
            catch (Exception)
            {
                Console.WriteLine("Error al consultar el Usuario");
            }

            return listaUsuarios;
        }

    }
}
