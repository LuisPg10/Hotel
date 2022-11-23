using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Datos;

namespace Logica
{
    public class ServicioGerente
    {
        Conexion conexion = new Conexion();
        public void EliminarAdministrador(int id)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand($"DELETE FROM administrador WHERE IdAdministrador = ({id})", conexion.obtenerConexion());
                comando.ExecuteNonQuery();
                Console.WriteLine("Administrador Eliminado!");
                conexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el administrador");
            }
        }
    }
}
