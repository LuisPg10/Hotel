using MySql.Data.MySqlClient;
using System;


namespace Datos
{
    public class Conexion
    {
        public static MySqlConnection conexion;

        //Metodo para establecer una conexion con la base de datos
        public MySqlConnection ObtenerConexion()
        {
            try
            {
                conexion = new MySqlConnection("server= localhost; database= bdhotel; Uid= root; pwd= ;");
                conexion.Open();
                Console.WriteLine("Conexion exitosa!");
                return conexion;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error {ex.Message}");
            }
            return conexion;
        }

        //Metodo para cerrar la conexion con la base de datos
        public void cerrarConexion()
        {
            try
            {
                conexion.Close();
                Console.WriteLine("Conexion cerrada!");
            }catch(Exception ex)
            {
                Console.WriteLine($"Error {ex.Message}");
                conexion.Close();
            }
        }

    }
}
