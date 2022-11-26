using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Entidades;

namespace Datos
{
    public class DatosGerente
    {
        Conexion conexion = new Conexion();

        //Metodo para registrar gerentes a traves de los datos de un objeto de tipo Gerente
        public void RegistrarGerente(Gerente user)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand($"Insert into gerentes values({0},'{user.Username}','{user.Password}')", conexion.ObtenerConexion());
                comando.ExecuteNonQuery();
                Console.WriteLine("Gerente Registrado!");
                conexion.cerrarConexion();
            }
            catch (Exception)
            {
                Console.WriteLine("Error al agregar los datos");
            }
        }

        //Metodo para eliminar gerentes teniendo en cuenta el id
        public void EliminarGerente(uint id)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand($"DELETE FROM gerentes WHERE IdGerente = {id}", conexion.ObtenerConexion());
                comando.ExecuteNonQuery();
                Console.WriteLine("Gerente Eliminado!");
                conexion.cerrarConexion();
            }
            catch (Exception)
            {
                Console.WriteLine("Error al eliminar el gerente");
            }
        }

        //Metodo para actualizar los datos de un gerente teniendo en cuenta el id y los datos de un objeto de tipo Gerente
        public void ActualizarGerente(uint id, Gerente user)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand($"UPDATE gerentes SET UserName = '{user.Username}', Pssword = '{user.Password}' WHERE IdGerente = {id}", conexion.ObtenerConexion());
                comando.ExecuteNonQuery();
                Console.WriteLine("Datos actualizados!");
                conexion.cerrarConexion();
            }
            catch (Exception)
            {
                Console.WriteLine("Error al actualizar los datos");
            }
        }

        //Metodo para consultar un gerente en la base de datos y si existe retorna un objeto de tipo Gerente con sus datos
        public Gerente ConsultarGerente(uint id)
        {
            Gerente user = new Gerente();
            try
            {
                MySqlCommand comando = new MySqlCommand($"SELECT * FROM gerentes WHERE IdGerente = '{id}'", conexion.ObtenerConexion());
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
                Console.WriteLine("Error al consultar el Gerente");
            }
            return user;
        }

        //Metodo para verificar la existencia de un UserName en la base de datos
        //Recomendado para el apartado de registrar gerentes
        public bool VerificarGerente(string username)
        {
            bool resultado = false;
            try
            {
                MySqlCommand comando = new MySqlCommand($"SELECT * FROM gerentes WHERE UserName = '{username}'", conexion.ObtenerConexion());
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
        public bool VerificarEntradaGerente(string username, string contra)
        {
            bool resultado = false;
            try
            {
                MySqlCommand comando = new MySqlCommand($"SELECT * FROM Gerentes WHERE UserName = '{username}' AND Pssword = '{contra}'", conexion.ObtenerConexion());
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

        //Metodo para cargar los datos de la tabla gerente en una lista
        public List<Gerente> ListaGerentes()
        {
            List<Gerente> listaGerente = new List<Gerente>();

            try
            {
                MySqlCommand comando = new MySqlCommand($"SELECT * FROM gerentes", conexion.ObtenerConexion());
                MySqlDataReader consulta = comando.ExecuteReader();
                while (consulta.Read())
                {
                    Gerente user = new Gerente();
                    user.Id = consulta.GetUInt32(0);
                    user.Username = consulta.GetString(1);
                    user.Password = consulta.GetString(2);
                    listaGerente.Add(user);
                }
                conexion.cerrarConexion();
            }
            catch (Exception)
            {
                Console.WriteLine("Error al consultar el gerente");
            }

            return listaGerente;
        }
    }
}
