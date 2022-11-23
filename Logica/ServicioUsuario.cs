using System;
using Entidades;
using System.Collections;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Datos;

namespace Logica
{
    public class ServicioUsuario
    {
        Conexion conexion= new Conexion();
        
        public void RegistrarUsuario(Usuario user)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand($"Insert into usuario values({0},'{user.Nombre}','{user.Correo}','{user.Username}','{user.Password}',{user.Habitacion.Id})", conexion.obtenerConexion());
                comando.ExecuteNonQuery();
                Console.WriteLine("Usuario Registrado!");
                conexion.cerrarConexion();
            }catch(Exception ex) { 
                Console.WriteLine("Error al agregar los datos");
            }
        }

    }
}
