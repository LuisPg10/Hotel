using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Datos;
using Entidades;

namespace Logica
{
    public class ServicioGerente
    {
        DatosGerente datos = new DatosGerente();

        //Metodo para registrar gerentes a traves de los datos de un objeto de tipo Gerente
        public void RegistrarGerente(Gerente user)
        {
            datos.RegistrarGerente(user);
        }

        //Metodo para eliminar gerentes teniendo en cuenta el id
        public void EliminarGerente(int id)
        {
            datos.EliminarGerente(id);
        }

        //Metodo para actualizar los datos de un gerente teniendo en cuenta el id y los datos de un objeto de tipo Gerente
        public void ActualizarGerente(int id, Gerente user)
        {
            datos.ActualizarGerente(id,user);
        }

        //Metodo para consultar un gerente en la base de datos y si existe retorna un objeto de tipo Gerente con sus datos
        public Gerente consultarGerente(int id)
        {
            return datos.consultarGerente(id);
        }

        //Metodo para verificar la existencia de un UserName en la base de datos
        //Recomendado para el apartado de registrar gerentes
        public bool verificarGerente(String username)
        {
            
            return datos.verificarGerente(username);
        }

        //Metodo para verificar la existencia del UserName y contraseña en la base de datos
        //Recomendado para el apartado de iniciar sesion
        public bool verificarEntradaGerente(String username, String contra)
        {
            return datos.verificarEntradaGerente(username,contra);
        }

        //Metodo para cargar los datos de la tabla gerente en una lista
        public List<Gerente> listaGerentes()
        {
            return datos.listaGerentes();
        }
    }
}
