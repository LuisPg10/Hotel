using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Entidades;

namespace Datos
{
    public class DatosAdministrador
    {
        Conexion conexion;
        public DatosAdministrador(Conexion conexion)
        {
            this.conexion = conexion;
        }

        //Metodo para registrar administradores a traves de los datos de un objeto de tipo Administrador
        public void RegistrarAdministrador(Administrador user)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand($"Insert into administradores values({0},'{user.Username}','{user.Password}')", conexion.ObtenerConexion());
                comando.ExecuteNonQuery();
                Console.WriteLine("Administrador Registrado!");
                conexion.cerrarConexion();
            }
            catch (Exception)
            {
                Console.WriteLine("Error al agregar los datos");
            }
        }

        //Metodo para eliminar administradores teniendo en cuenta el id
        public void EliminarAdministrador(uint id)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand($"DELETE FROM administradores WHERE IdAdministrador = {id}", conexion.ObtenerConexion());
                comando.ExecuteNonQuery();
                Console.WriteLine("Administrador Eliminado!");
                conexion.cerrarConexion();
            }
            catch (Exception)
            {
                Console.WriteLine("Error al eliminar el administrador");
            }
        }

        //Metodo para actualizar los datos de un administrador teniendo en cuenta el id y los datos de un objeto de tipo Administrador
        public void ActualizarGerente(uint id, Administrador user)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand($"UPDATE administradores SET UserName = '{user.Username}', Pssword = '{user.Password}' WHERE IdAdministrador = {id}", conexion.ObtenerConexion());
                comando.ExecuteNonQuery();
                Console.WriteLine("Datos actualizados!");
                conexion.cerrarConexion();
            }
            catch (Exception)
            {
                Console.WriteLine("Error al actualizar los datos");
            }
        }

        //Metodo para consultar un administrador en la base de datos y si existe retorna un objeto de tipo Administrador con sus datos
        public Administrador consultarAdministrador(uint id)
        {
            Administrador user = new Administrador();
            try
            {
                MySqlCommand comando = new MySqlCommand($"SELECT * FROM administradores WHERE IdAdministrador = '{id}'", conexion.ObtenerConexion());
                MySqlDataReader consulta = comando.ExecuteReader();
                while (consulta.Read())
                {
                    if (consulta.GetUInt32(0) == id)
                    {
                        user.Id = consulta.GetUInt32(0);
                        user.Username = consulta.GetString(1);
                        user.Password = consulta.GetString(2);
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
                Console.WriteLine("Error al consultar el administrador");
            }
            return user;
        }

        //Metodo para verificar la existencia de un UserName en la base de datos
        //Recomendado para el apartado de registrar administradores
        public bool verificarAdministrador(string username)
        {
            bool resultado = false;
            try
            {
                MySqlCommand comando = new MySqlCommand($"SELECT * FROM administradores WHERE UserName = '{username}'", conexion.ObtenerConexion());
                MySqlDataReader consulta = comando.ExecuteReader();
                while (consulta.Read())
                {
                    if (consulta.GetString(1).Equals(username))
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

        //Metodo para verificar la existencia del UserName y contraseña en la base de datos
        //Recomendado para el apartado de iniciar sesion
        public bool verificarEntradaAdministrador(string username, string contra)
        {
            bool resultado = false;
            try
            {
                MySqlCommand comando = new MySqlCommand($"SELECT * FROM administradores WHERE UserName = '{username}' AND Pssword = '{contra}'", conexion.ObtenerConexion());
                MySqlDataReader consulta = comando.ExecuteReader();
                while (consulta.Read())
                {
                    if (consulta.GetString(1).Equals(username) && consulta.GetString(2).Equals(contra))
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

        //Metodo para cargar los datos de la tabla administrador en una lista
        public List<Administrador> ListaAdministradores()
        {
            List<Administrador> listaAdministrador = new List<Administrador>();

            try
            {
                MySqlCommand comando = new MySqlCommand($"SELECT * FROM administradores", conexion.ObtenerConexion());
                MySqlDataReader consulta = comando.ExecuteReader();
                while (consulta.Read())
                {
                    Administrador user = new Administrador();
                    user.Id = consulta.GetUInt32(0);
                    user.Username = consulta.GetString(1);
                    user.Password = consulta.GetString(2);
                    listaAdministrador.Add(user);
                }
                conexion.cerrarConexion();
            }
            catch (Exception)
            {
                Console.WriteLine("Error al consultar el administrador");
            }

            return listaAdministrador;
        }
    }
}
