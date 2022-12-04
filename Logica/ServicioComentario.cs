using System.Collections.Generic;
using Entidades;
using Datos;

namespace Logica
{
    public class ServicioComentario
    {
        DatosComentario datos = new DatosComentario(ServicioAdministrador.conexion);

        //Metodo para registrar comentarios a traves de los datos de un objeto de tipo Usuario, habitacion y un dato de tipo string
        public void RegistrarComentario(Comentario comentario)
        {
            datos.RegistrarComentario(comentario);
        }

        //Metodo para eliminar un comentario teniendo en cuenta el id
        public void EliminarComentario(uint id)
        {
            datos.EliminarComentario(id);
        }

        //Metodo para consultar un comentario en la base de datos y si existe retorna un objetos de tipo comentario con sus datos
        public Comentario ConsultarComentario(uint id)
        {
            
            return datos.ConsultarComentario(id);
        }

        //Metodo para cargar los datos de la tabla comentario en una lista
        public List<Comentario> ListaComentarios()
        {
            
            return datos.ListaComentarios();
        }

    }
}
