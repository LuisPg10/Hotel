using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Datos;
using Entidades;

namespace Logica
{
    public class DatosAdministrador
    {
        Conexion conexion = new Conexion();

        //Metodo para registrar administradores a traves de los datos de un objeto de tipo Administrador
        public void RegistrarAdministrador(Administrador user)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand($"Insert into administrador values({0},'{user.Nombre}','{user.Correo}','{user.Username}','{user.Password}')", conexion.obtenerConexion());
                comando.ExecuteNonQuery();
                Console.WriteLine("Administrador Registrado!");
                conexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar los datos");
            }
        }

        //Metodo para eliminar administradores teniendo en cuenta el id
        public void EliminarAdministrador(int id)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand($"DELETE FROM administrador WHERE IdAdministrador = {id}", conexion.obtenerConexion());
                comando.ExecuteNonQuery();
                Console.WriteLine("Administrador Eliminado!");
                conexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el administrador");
            }
        }

        //Metodo para actualizar los datos de un administrador teniendo en cuenta el id y los datos de un objeto de tipo Administrador
        public void ActualizarGerente(int id, Administrador user)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand($"UPDATE administrador SET Nombre = '{user.Nombre}', Correo = '{user.Correo}', UserName = '{user.Username}', Contraseña = '{user.Password}' WHERE IdAdministrador = {id}", conexion.obtenerConexion());
                comando.ExecuteNonQuery();
                Console.WriteLine("Datos actualizados!");
                conexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar los datos");
            }
        }

        //Metodo para consultar un administrador en la base de datos y si existe retorna un objeto de tipo Administrador con sus datos
        public Administrador consultarAdministrador(int id)
        {
            Administrador user = new Administrador();
            try
            {
                MySqlCommand comando = new MySqlCommand($"SELECT * FROM administrador WHERE IdAdministrador = '{id}'", conexion.obtenerConexion());
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
                Console.WriteLine("Error al consultar el administrador");
            }
            return user;
        }

        //Metodo para verificar la existencia de un UserName en la base de datos
        //Recomendado para el apartado de registrar administradores
        public bool verificarAdministrador(String username)
        {
            bool resultado = false;
            try
            {
                MySqlCommand comando = new MySqlCommand($"SELECT * FROM administrador WHERE UserName = '{username}'", conexion.obtenerConexion());
                MySqlDataReader consulta = comando.ExecuteReader();
                while (consulta.Read())
                {
                    if (consulta.GetString(3).Equals(username))
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
        //Recomendado para el apartado de iniciar sesion
        public bool verificarEntradaAdministrador(String username, String contra)
        {
            bool resultado = false;
            try
            {
                MySqlCommand comando = new MySqlCommand($"SELECT * FROM administrador WHERE UserName = '{username}' AND Contraseña = '{contra}'", conexion.obtenerConexion());
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

        //Metodo para cargar los datos de la tabla administrador en una lista
        public List<Administrador> listaAdministradores()
        {
            List<Administrador> listaAdministrador = new List<Administrador>();

            try
            {
                MySqlCommand comando = new MySqlCommand($"SELECT * FROM administrador", conexion.obtenerConexion());
                MySqlDataReader consulta = comando.ExecuteReader();
                while (consulta.Read())
                {
                    Administrador user = new Administrador();
                    user.Id = consulta.GetUInt32(0);
                    user.Nombre = consulta.GetString(1);
                    user.Correo = consulta.GetString(2);
                    user.Username = consulta.GetString(3);
                    user.Password = consulta.GetString(4);
                    listaAdministrador.Add(user);
                }
                conexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al consultar el administrador");
            }

            return listaAdministrador;
        }
    }
}
