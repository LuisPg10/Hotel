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
    public class ServicioAdministrador
    {
        Conexion conexion = new Conexion();
        public void EliminarUsuario(int id)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand($"DELETE FROM usuario WHERE IdUsuario = ({id})", conexion.obtenerConexion());
                comando.ExecuteNonQuery();
                Console.WriteLine("Usuario Eliminado!");
                conexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el usuario");
            }
        }
    }
}
