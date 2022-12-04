using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
    public class DatosHabitacion
    {
        Conexion conexion;
        public DatosHabitacion(Conexion conexion)
        {
            this.conexion = conexion;
        }

        //Metodo para registrar Habitaciones a traves de los datos de un objeto de tipo Habitacion
        public void RegistrarHabitacion(Habitacion habitacion)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand($"INSERT INTO habitaciones VALUES({habitacion.Id},{habitacion.NumHabitacion},'{habitacion.TipoHabitacion}',{habitacion.Precio},{habitacion.Usuario.Id})", conexion.ObtenerConexion());
                comando.ExecuteNonQuery();
                Console.WriteLine("Habitacion Registrada!");
                conexion.cerrarConexion();
            }
            catch (Exception)
            {
                Console.WriteLine("Error al agregar los datos");
            }
        }

        //Metodo para eliminar una habitacion teniendo en cuenta el id
        public void EliminarHabitacion(uint id)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand($"DELETE FROM habitaciones WHERE IdHabitacion = {id}", conexion.ObtenerConexion());
                comando.ExecuteNonQuery();
                Console.WriteLine("Habitacion Eliminada!");
                conexion.cerrarConexion();
            }
            catch (Exception)
            {
                Console.WriteLine("Error al eliminar la habitacion");
            }
        }

        //Metodo para actualizar los datos de una habitacion teniendo en cuenta el id y los datos de un objeto de tipo Habitacion
        public void ActualizarHabitacion(Habitacion habitacion)
        {
            try
            {
                MySqlCommand comando;

                if (habitacion.Usuario != null)
                {
                    comando = new MySqlCommand($"UPDATE habitaciones SET IdUsuario = '{habitacion.Usuario.Id}' WHERE IdHabitacion = {habitacion.Id}", conexion.ObtenerConexion());
                }
                else
                {
                    comando = new MySqlCommand($"UPDATE habitaciones SET IdUsuario = NULL WHERE IdHabitacion = {habitacion.Id}", conexion.ObtenerConexion());
                }
                comando.ExecuteNonQuery();
                Console.WriteLine("Datos actualizados!");
                conexion.cerrarConexion();
            }
            catch (Exception)
            {
                Console.WriteLine("Error al actualizar los datos");
            }
        }

        //Metodo para consultar una habitacion en la base de datos y si existe retorna un objetos de tipo Habitacion con sus datos
        public Habitacion ConsultarHabitacion(uint id)
        {
            var habitacion = new Habitacion();
            try
            {
                MySqlCommand comando = new MySqlCommand($"SELECT * FROM habitaciones WHERE IdHabitacion = {id}", conexion.ObtenerConexion());
                MySqlDataReader consulta = comando.ExecuteReader();
                while (consulta.Read())
                {
                    if (consulta.GetUInt32(0) == id)
                    {
                        habitacion.Id = consulta.GetUInt32(0);
                        habitacion.Nombre = consulta.GetString(1);
                        habitacion.NumHabitacion = consulta.GetInt32(2);
                        habitacion.TipoHabitacion = consulta.GetString(3);
                        habitacion.Descripcion = consulta.GetString(4);
                        habitacion.Precio = consulta.GetDouble(5);
                    }
                    else
                    {
                        habitacion = null;
                    }
                }
                conexion.cerrarConexion();
            }
            catch (Exception)
            {
                Console.WriteLine("Error al consultar la habitacion");
            }
            return habitacion;
        }

        //Metodo para cargar los datos de la tabla habitacion en una lista
        public List<Habitacion> ListaHabitaciones()
        {
            List<Habitacion> listahabitacion = new List<Habitacion>();
            try
            {
                MySqlCommand comando = new MySqlCommand($"SELECT * FROM habitaciones", conexion.ObtenerConexion());
                MySqlDataReader consulta = comando.ExecuteReader();
                while (consulta.Read())
                {
                    var habitacion = new Habitacion
                    {
                        Id = consulta.GetUInt32(0),
                        Nombre = consulta.GetString(1),
                        NumHabitacion = consulta.GetInt32(2),
                        TipoHabitacion = consulta.GetString(3),
                        Descripcion = consulta.GetString(4),
                        Precio = consulta.GetDouble(5)
                    };

                    if (!DBNull.Value.Equals(consulta.GetValue(6)))
                    {
                        habitacion.Usuario = new DatosUsuario().ConsultarUsuario(consulta.GetUInt32(6));
                    }

                    listahabitacion.Add(habitacion);
                }
                conexion.cerrarConexion();
            }
            catch (Exception)
            {
                Console.WriteLine("Error al consultar la habitacion");
            }
            return listahabitacion;
        }

    }
}
