using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace Datos
{
    public class Conexion
    {
        public static MySqlConnection conectar;

        public MySqlConnection obtenerConexion()
        {
            try
            {
                conectar = new MySqlConnection("server = 127.0.0.1; database = bdhotel; Uid = root; pwd = ;");
                conectar.Open();
                Console.WriteLine("Conexion exitosa!");
                return conectar;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error {ex.Message}");
            }
            return conectar;
        }

        public void cerrarConexion()
        {
            try
            {
                conectar.Close();
                Console.WriteLine("Conexion cerrada!");
            }catch(Exception ex)
            {
                Console.WriteLine($"Error {ex.Message}");
                conectar.Close();
            }
        }

    }
}
