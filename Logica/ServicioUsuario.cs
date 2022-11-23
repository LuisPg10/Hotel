using System;
using Entidades;
using System.Collections;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Datos;

namespace Logica
{
    public class ServicioUsuario
    {
        Conexion conexion= new Conexion();
        

        //Metodo para registrar usuarios a traves de los datos de un objeto de tipo Usuario
        public void RegistrarUsuario(Usuario user)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand($"INSERT INTO usuario VALUES({0},'{user.Nombre}','{user.Correo}','{user.Username}','{user.Password}',{user.Habitacion.Id})", conexion.obtenerConexion());
                comando.ExecuteNonQuery();
                Console.WriteLine("Usuario Registrado!");
                conexion.cerrarConexion();
            }catch(Exception ex) { 
                Console.WriteLine("Error al agregar los datos");
            }
        }

        //Metodo para eliminar usuarios teniendo en cuenta el id
        public void EliminarUsuario(int id)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand($"DELETE FROM usuario WHERE IdUsuario = {id}", conexion.obtenerConexion());
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
        public void ActualizarUsuario(int id, Usuario user)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand($"UPDATE usuario SET Nombre = '{user.Nombre}', Correo = '{user.Correo}', UserName = '{user.Username}', Contraseña = '{user.Password}', IdHabitacion = {user.Habitacion.Id} WHERE IdUsuario = {id}", conexion.obtenerConexion());
                comando.ExecuteNonQuery();
                Console.WriteLine("Datos actualizados!");
                conexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar los datos");
            }
        }

        //Metodo para verificar la existencia de un UserName en la base de datos
        public bool verificarUsuario(String username)
        {
            bool resultado = false;
            try
            {
                MySqlCommand comando = new MySqlCommand($"SELECT * FROM usuario WHERE UserName = '{username}'", conexion.obtenerConexion());
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

        //Metodo para verificar la existencia del UserName y contraseña en la base de datos
        public bool verificarEntrada(String username,String contra)
        {
            bool resultado = false;
            try
            {
                MySqlCommand comando = new MySqlCommand($"SELECT * FROM usuario WHERE UserName = '{username}' AND Contraseña = '{contra}'", conexion.obtenerConexion());
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
    }
}
