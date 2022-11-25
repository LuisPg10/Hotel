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
    public class ServicioComentario
    {
        DatosComentario datos = new DatosComentario();

        //Metodo para registrar comentarios a traves de los datos de un objeto de tipo Usuario, habitacion y un dato de tipo string
        public void RegistrarComentario(Comentario comentario)
        {
            datos.RegistrarComentario(comentario);
        }

        //Metodo para eliminar un comentario teniendo en cuenta el id
        public void EliminarComentario(int id)
        {
            datos.EliminarComentario(id);
        }

        //Metodo para consultar un comentario en la base de datos y si existe retorna un objetos de tipo comentario con sus datos
        public Comentario consultarComentario(int id)
        {
            
            return datos.consultarComentario(id);
        }

        //Metodo para cargar los datos de la tabla comentario en una lista
        public List<Comentario> listaComentarios()
        {
            
            return datos.listaComentarios();
        }

    }
}
