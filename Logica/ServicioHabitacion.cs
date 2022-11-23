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
    public class ServicioHabitacion
    {
        Conexion conexion = new Conexion();

        //Metodo para consultar una habitacion en la base de datos y si existe retorna un objetos de tipo Habitacion con sus datos
        public Habitacion consultarHabitacion(int id)
        {
            Habitacion habitacion = new Habitacion();
            try
            {
                MySqlCommand comando = new MySqlCommand($"SELECT * FROM habitacion WHERE IdHabitacion = {id}", conexion.obtenerConexion());
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
                Console.WriteLine("Error al consultar el usuario");
            }
            return habitacion;
        }
    }
}
