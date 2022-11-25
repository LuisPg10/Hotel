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
        DatosHabitacion datos = new DatosHabitacion();

        //Metodo para registrar Habitaciones a traves de los datos de un objeto de tipo Habitacion
        public void RegistrarHabitacion(Habitacion habitacion)
        {
            datos.RegistrarHabitacion(habitacion);
        }

        //Metodo para eliminar una habitacion teniendo en cuenta el id
        public void EliminarHabitacion(int id)
        {
            datos.EliminarHabitacion(id);
        }

        //Metodo para actualizar los datos de una habitacion teniendo en cuenta el id y los datos de un objeto de tipo Habitacion
        public void ActualizarHabitacion(int id, Habitacion habitacion)
        {
            datos.ActualizarHabitacion(id,habitacion);
        }

        //Metodo para consultar una habitacion en la base de datos y si existe retorna un objetos de tipo Habitacion con sus datos
        public Habitacion consultarHabitacion(int id)
        {
            return datos.consultarHabitacion(id);
        }

        //Metodo para cargar los datos de la tabla habitacion en una lista
        public List<Habitacion> listaHabitaciones()
        {
            
            return datos.listaHabitaciones();
        }

    }
}
