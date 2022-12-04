using System.Collections.Generic;
using Datos;
using Entidades;

namespace Logica
{
    public class ServicioGerente
    {
        DatosGerente datos = new DatosGerente(ServicioAdministrador.conexion);

        //Metodo para registrar gerentes a traves de los datos de un objeto de tipo Gerente
        public void RegistrarGerente(Gerente user)
        {
            datos.RegistrarGerente(user);
        }

        //Metodo para eliminar gerentes teniendo en cuenta el id
        public void EliminarGerente(uint id)
        {
            datos.EliminarGerente(id);
        }

        //Metodo para actualizar los datos de un gerente teniendo en cuenta el id y los datos de un objeto de tipo Gerente
        public void ActualizarGerente(uint id, Gerente user)
        {
            datos.ActualizarGerente(id,user);
        }

        //Metodo para consultar un gerente en la base de datos y si existe retorna un objeto de tipo Gerente con sus datos
        public Gerente ConsultarGerente(uint id)
        {
            return datos.ConsultarGerente(id);
        }

        //Metodo para verificar la existencia de un UserName en la base de datos
        //Recomendado para el apartado de registrar gerentes
        public bool VerificarGerente(string username)
        {
            return datos.VerificarGerente(username);
        }

        //Metodo para verificar la existencia del UserName y contraseña en la base de datos
        //Recomendado para el apartado de iniciar sesion
        public bool VerificarEntradaGerente(string username, string contra)
        {
            return datos.VerificarEntradaGerente(username,contra);
        }

        //Metodo para cargar los datos de la tabla gerente en una lista
        public List<Gerente> ListaGerentes()
        {
            return datos.ListaGerentes();
        }
    }
}
