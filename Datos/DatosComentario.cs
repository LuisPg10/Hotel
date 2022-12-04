using System;
using System.Collections.Generic;
using Entidades;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class DatosComentario
    {
        Conexion conexion;
        public DatosComentario(Conexion conexion)
        {
            this.conexion = conexion;
        }

        //Metodo para registrar comentarios a traves de los datos de un objeto de tipo Usuario, habitacion y un dato de tipo string
        public void RegistrarComentario(Comentario comentario)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand($"INSERT INTO comentarios VALUES({0},{comentario.Usuario.Id},{comentario.Habitacion.Id},'{comentario.Comentarios}')", conexion.ObtenerConexion());
                comando.ExecuteNonQuery();
                Console.WriteLine("Comentario Registrado!");
                conexion.cerrarConexion();
            }
            catch (Exception)
            {
                Console.WriteLine("Error al agregar los datos");
            }
        }

        //Metodo para eliminar un comentario teniendo en cuenta el id
        public void EliminarComentario(uint id)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand($"DELETE FROM comentarios WHERE IdComentario = {id}", conexion.ObtenerConexion());
                comando.ExecuteNonQuery();
                Console.WriteLine("Comentario Eliminado!");
                conexion.cerrarConexion();
            }
            catch (Exception)
            {
                Console.WriteLine("Error al eliminar el comentario");
            }
        }

        //Metodo para consultar un comentario en la base de datos y si existe retorna un objetos de tipo comentario con sus datos
        public Comentario ConsultarComentario(uint id)
        {
            Comentario comentario = new Comentario();
            try
            {
                MySqlCommand comando = new MySqlCommand($"SELECT * FROM comentarios WHERE IdComentario = {id}", conexion.ObtenerConexion());
                MySqlDataReader consulta = comando.ExecuteReader();
                while (consulta.Read())
                {
                    if (consulta.GetUInt32(0) == id)
                    {
                        comentario.Id = consulta.GetUInt32(0);
                        comentario.Usuario = new DatosUsuario().ConsultarUsuario(consulta.GetString(3));
                        comentario.Habitacion = new DatosHabitacion().ConsultarHabitacion(consulta.GetUInt32(1));
                        comentario.Comentarios = consulta.GetString(3);
                    }
                    else
                    {
                        comentario = null;
                    }
                }
                conexion.cerrarConexion();
            }
            catch (Exception)
            {
                Console.WriteLine("Error al consultar el comentario");
            }
            return comentario;
        }

        //Metodo para cargar los datos de la tabla comentario en una lista
        public List<Comentario> ListaComentarios()
        {
            List<Comentario> listaComentario = new List<Comentario>();
            try
            {
                MySqlCommand comando = new MySqlCommand($"SELECT * FROM comentarios", conexion.ObtenerConexion());
                MySqlDataReader consulta = comando.ExecuteReader();
                while (consulta.Read())
                {
                    Comentario comentario = new Comentario();
                    comentario.Id = consulta.GetUInt32(0);
                    comentario.Usuario = new DatosUsuario().ConsultarUsuario(consulta.GetUInt32(1));
                    comentario.Habitacion = new DatosHabitacion().ConsultarHabitacion(consulta.GetUInt32(2));
                    comentario.Comentarios = consulta.GetString(3);
                    listaComentario.Add(comentario);
                }
                conexion.cerrarConexion();
            }
            catch (Exception)
            {
                Console.WriteLine("Error al consultar el comentario");
            }
            return listaComentario;
        }

    }
}
