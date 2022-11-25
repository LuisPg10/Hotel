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
    public class DatosGerente
    {
        Conexion conexion = new Conexion();

        //Metodo para registrar gerentes a traves de los datos de un objeto de tipo Gerente
        public void RegistrarGerente(Gerente user)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand($"Insert into gerente values({0},'{user.Nombre}','{user.Correo}','{user.Username}','{user.Password}')", conexion.obtenerConexion());
                comando.ExecuteNonQuery();
                Console.WriteLine("Gerente Registrado!");
                conexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar los datos");
            }
        }

        //Metodo para eliminar gerentes teniendo en cuenta el id
        public void EliminarGerente(int id)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand($"DELETE FROM gerente WHERE IdGerente = {id}", conexion.obtenerConexion());
                comando.ExecuteNonQuery();
                Console.WriteLine("Gerente Eliminado!");
                conexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el gerente");
            }
        }

        //Metodo para actualizar los datos de un gerente teniendo en cuenta el id y los datos de un objeto de tipo Gerente
        public void ActualizarGerente(int id, Gerente user)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand($"UPDATE gerente SET Nombre = '{user.Nombre}', Correo = '{user.Correo}', UserName = '{user.Username}', Contraseña = '{user.Password}' WHERE IdGerente = {id}", conexion.obtenerConexion());
                comando.ExecuteNonQuery();
                Console.WriteLine("Datos actualizados!");
                conexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar los datos");
            }
        }

        //Metodo para consultar un gerente en la base de datos y si existe retorna un objeto de tipo Gerente con sus datos
        public Gerente consultarGerente(int id)
        {
            Gerente user = new Gerente();
            try
            {
                MySqlCommand comando = new MySqlCommand($"SELECT * FROM gerente WHERE IdGerente = '{id}'", conexion.obtenerConexion());
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
                Console.WriteLine("Error al consultar el Gerente");
            }
            return user;
        }

        //Metodo para verificar la existencia de un UserName en la base de datos
        //Recomendado para el apartado de registrar gerentes
        public bool verificarGerente(String username)
        {
            bool resultado = false;
            try
            {
                MySqlCommand comando = new MySqlCommand($"SELECT * FROM gerente WHERE UserName = '{username}'", conexion.obtenerConexion());
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
        public bool verificarEntradaGerente(String username, String contra)
        {
            bool resultado = false;
            try
            {
                MySqlCommand comando = new MySqlCommand($"SELECT * FROM Gerente WHERE UserName = '{username}' AND Contraseña = '{contra}'", conexion.obtenerConexion());
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

        //Metodo para cargar los datos de la tabla gerente en una lista
        public List<Gerente> listaGerentes()
        {
            List<Gerente> listaGerente = new List<Gerente>();

            try
            {
                MySqlCommand comando = new MySqlCommand($"SELECT * FROM gerente", conexion.obtenerConexion());
                MySqlDataReader consulta = comando.ExecuteReader();
                while (consulta.Read())
                {
                    Gerente user = new Gerente();
                    user.Id = consulta.GetUInt32(0);
                    user.Nombre = consulta.GetString(1);
                    user.Correo = consulta.GetString(2);
                    user.Username = consulta.GetString(3);
                    user.Password = consulta.GetString(4);
                    listaGerente.Add(user);
                }
                conexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al consultar el gerente");
            }

            return listaGerente;
        }
    }
}
