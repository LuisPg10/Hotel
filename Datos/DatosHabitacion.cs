using Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlX.XDevAPI;
using System.Diagnostics.Contracts;
using Entidades;

namespace Logica
{
    public class DatosHabitacion
    {
        Conexion conexion = new Conexion();

        //Metodo para registrar Habitaciones a traves de los datos de un objeto de tipo Habitacion
        public void RegistrarHabitacion(Habitacion habitacion)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand($"INSERT INTO habitacion VALUES({0},{habitacion.NumHabitacion},'{habitacion.TipoHabitacion}',{habitacion.Precio})", conexion.ObtenerConexion());
                comando.ExecuteNonQuery();
                Console.WriteLine("Habitacion Registrada!");
                conexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar los datos");
            }
        }

        //Metodo para eliminar una habitacion teniendo en cuenta el id
        public void EliminarHabitacion(uint id)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand($"DELETE FROM habitacion WHERE IdHabitacion = {id}", conexion.ObtenerConexion());
                comando.ExecuteNonQuery();
                Console.WriteLine("Habitacion Eliminada!");
                conexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar la habitacion");
            }
        }

        //Metodo para actualizar los datos de una habitacion teniendo en cuenta el id y los datos de un objeto de tipo Habitacion
        public void ActualizarHabitacion(uint id, Habitacion habitacion)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand($"UPDATE habitacion SET NunHabitacion = '{habitacion.NumHabitacion}', TipoHabitacion = '{habitacion.TipoHabitacion}', Precio = '{habitacion.Precio}' WHERE IdHabitacion = {id}", conexion.ObtenerConexion());
                comando.ExecuteNonQuery();
                Console.WriteLine("Datos actualizados!");
                conexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar los datos");
            }
        }

        //Metodo para consultar una habitacion en la base de datos y si existe retorna un objetos de tipo Habitacion con sus datos
        public Habitacion ConsultarHabitacion(uint id)
        {
            Habitacion habitacion = new Habitacion();
            try
            {
                MySqlCommand comando = new MySqlCommand($"SELECT * FROM habitacion WHERE IdHabitacion = {id}", conexion.ObtenerConexion());
                MySqlDataReader consulta = comando.ExecuteReader();
                while (consulta.Read())
                {
                    if (consulta.GetUInt32(0)==id)
                    {
                        habitacion.Id = consulta.GetUInt32(0);
                        habitacion.NumHabitacion = consulta.GetInt32(1);
                        habitacion.TipoHabitacion = consulta.GetString(2);
                        habitacion.Precio = consulta.GetDouble(4);

                    }
                    else
                    {
                        habitacion = null;
                    }
                }
                conexion.cerrarConexion();
            }
            catch (Exception ex)
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
                MySqlCommand comando = new MySqlCommand($"SELECT * FROM habitacion", conexion.ObtenerConexion());
                MySqlDataReader consulta = comando.ExecuteReader();
                while (consulta.Read())
                {
                    Habitacion habitacion = new Habitacion();
                        habitacion.Id = consulta.GetUInt32(0);
                        habitacion.NumHabitacion = consulta.GetInt32(1);
                        habitacion.TipoHabitacion = consulta.GetString(2);
                        habitacion.Precio = consulta.GetDouble(4);
                    listahabitacion.Add(habitacion);

                }
                conexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al consultar la habitacion");
            }
            return listahabitacion;
        }

    }
}
