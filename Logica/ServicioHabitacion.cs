using System.Collections.Generic;
using Entidades;
using Datos;

namespace Logica
{
    public class ServicioHabitacion
    {
        DatosHabitacion datos = new DatosHabitacion(ServicioAdministrador.conexion);

        //Metodo para registrar Habitaciones a traves de los datos de un objeto de tipo Habitacion
        public void RegistrarHabitacion(Habitacion habitacion)
        {
            datos.RegistrarHabitacion(habitacion);
        }

        //Metodo para eliminar una habitacion teniendo en cuenta el id
        public void EliminarHabitacion(uint id)
        {
            datos.EliminarHabitacion(id);
        }

        //Metodo para actualizar los datos de una habitacion teniendo en cuenta el id y los datos de un objeto de tipo Habitacion
        public void ActualizarHabitacion(Habitacion habitacion)
        {
            datos.ActualizarHabitacion(habitacion);
        }

        //Metodo para consultar una habitacion en la base de datos y si existe retorna un objetos de tipo Habitacion con sus datos
        public Habitacion ConsultarHabitacion(uint id)
        {
            return datos.ConsultarHabitacion(id);
        }

        //Metodo para cargar los datos de la tabla habitacion en una lista
        public List<Habitacion> ListaHabitaciones()
        {
            
            return datos.ListaHabitaciones();
        }

    }
}
