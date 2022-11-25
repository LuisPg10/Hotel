using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlX.XDevAPI;
using System.Diagnostics.Contracts;
using Entidades;
using Datos;
using MySql.Data.MySqlClient;

namespace Logica
{
    public class DatosComentario
    {
        Conexion conexion = new Conexion();

        //Metodo para registrar comentarios a traves de los datos de un objeto de tipo Usuario, habitacion y un dato de tipo string
        public void RegistrarComentario(Comentario comentario)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand($"INSERT INTO comentario VALUES({0},{comentario.Usuario.Id},{comentario.Habitacion.Id},'{comentario.Comentarios}')", conexion.obtenerConexion());
                comando.ExecuteNonQuery();
                Console.WriteLine("Comentario Registrado!");
                conexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar los datos");
            }
        }

        //Metodo para eliminar un comentario teniendo en cuenta el id
        public void EliminarComentario(int id)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand($"DELETE FROM comentario WHERE IdComentario = {id}", conexion.obtenerConexion());
                comando.ExecuteNonQuery();
                Console.WriteLine("Comentario Eliminado!");
                conexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el comentario");
            }
        }

        //Metodo para consultar un comentario en la base de datos y si existe retorna un objetos de tipo comentario con sus datos
        public Comentario consultarComentario(int id)
        {
            Comentario comentario = new Comentario();
            try
            {
                MySqlCommand comando = new MySqlCommand($"SELECT * FROM comentario WHERE IdComentario = {id}", conexion.obtenerConexion());
                MySqlDataReader consulta = comando.ExecuteReader();
                while (consulta.Read())
                {
                    if (consulta.GetUInt32(0) == id)
                    {
                        comentario.Id = consulta.GetUInt32(0);
                        comentario.Usuario = new DatosUsuario().consultarUsuario(consulta.GetInt32(1));
                        comentario.Habitacion = new DatosHabitacion().consultarHabitacion(consulta.GetInt32(1));
                        comentario.Comentarios = consulta.GetString(3);
                    }
                    else
                    {
                        comentario = null;
                    }
                }
                conexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al consultar el comentario");
            }
            return comentario;
        }

        //Metodo para cargar los datos de la tabla comentario en una lista
        public List<Comentario> listaComentarios()
        {
            List<Comentario> listaComentario = new List<Comentario>();
            try
            {
                MySqlCommand comando = new MySqlCommand($"SELECT * FROM comentario", conexion.obtenerConexion());
                MySqlDataReader consulta = comando.ExecuteReader();
                while (consulta.Read())
                {
                    Comentario comentario = new Comentario();
                    comentario.Id = consulta.GetUInt32(0);
                    comentario.Usuario = new DatosUsuario().consultarUsuario(consulta.GetInt32(1));
                    comentario.Habitacion = new DatosHabitacion().consultarHabitacion(consulta.GetInt32(1));
                    comentario.Comentarios = consulta.GetString(3);
                    listaComentario.Add(comentario);

                }
                conexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al consultar el comentario");
            }
            return listaComentario;
        }

    }
}
