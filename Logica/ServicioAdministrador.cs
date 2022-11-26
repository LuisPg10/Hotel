using Datos;
using System.Collections.Generic;
using Entidades;

namespace Logica
{

    public class ServicioAdministrador
    {
        DatosAdministrador datos = new DatosAdministrador();

        //Metodo para registrar administradores a traves de los datos de un objeto de tipo Administrador
        public void RegistrarAdministrador(Administrador user)
        {
            datos.RegistrarAdministrador(user);
        }

        //Metodo para eliminar administradores teniendo en cuenta el id
        public void EliminarAdministrador(uint id)
        {
            datos.EliminarAdministrador(id);
        }

        //Metodo para actualizar los datos de un administrador teniendo en cuenta el id y los datos de un objeto de tipo Administrador
        public void ActualizarGerente(uint id, Administrador user)
        {
            datos.ActualizarGerente(id, user);
        }

        //Metodo para consultar un administrador en la base de datos y si existe retorna un objeto de tipo Administrador con sus datos
        public Administrador consultarAdministrador(uint id)
        {

            return datos.consultarAdministrador(id);
        }

        //Metodo para verificar la existencia de un UserName en la base de datos
        //Recomendado para el apartado de registrar administradores
        public bool verificarAdministrador(string username)
        {

            return datos.verificarAdministrador(username);
        }

        //Metodo para verificar la existencia del UserName y contraseña en la base de datos
        //Recomendado para el apartado de iniciar sesion
        public bool verificarEntradaAdministrador(string username, string contra)
        {
            return datos.verificarEntradaAdministrador(username, contra);
        }

        //Metodo para cargar los datos de la tabla administrador en una lista
        public List<Administrador> ListaAdministradores()
        {
            return datos.ListaAdministradores();
        }
    }
}
