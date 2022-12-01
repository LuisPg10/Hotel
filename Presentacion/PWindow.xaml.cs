using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para PWindow.xaml
    /// </summary>
    public partial class PWindow : UserControl
    {
        ServicioHabitacion servicioHabitacion;
        Usuario usuario;
        List<Habitacion> habitaciones;
        List<Rooms> rooms;
        NotRoom noHabitacion;
        YesRoom siHabitacion;

        public PWindow(Usuario usuario)
        {
            InitializeComponent();
            servicioHabitacion = new ServicioHabitacion();
            habitaciones = servicioHabitacion.ListaHabitaciones();
            this.usuario = usuario;
            rooms = new List<Rooms>();
            noHabitacion = new NotRoom();
            siHabitacion = new YesRoom();

            CargarHabitaciones();
            ListarHabitaciones();
        }
        
        //Metodo para controlar la vista despues del ingreso
        private void btnRoom_Back_Click(object sender, RoutedEventArgs e)
        {
            contenedorPersonal.Children.Clear();
            if (labelTitulo.Content.Equals($" Bienvenido {usuario.Nombre} "))
            {
                labelTitulo.Content = " Habitación ";
                btnRoom_Back.Content = "←";

                if (usuario.Habitacion == null)
                {
                    noHabitacion.SetText("No has reservado habitación");
                    contenedorPersonal.Children.Add(noHabitacion);
                }
                else
                {
                    siHabitacion.setContext(usuario.Habitacion, usuario, 
                        contenedorPersonal, labelTitulo, btnRoom_Back, rooms);
                    contenedorPersonal.Children.Add(siHabitacion);
                }
            }
            else
            {
                labelTitulo.Content = $" Bienvenido {usuario.Nombre} ";
                btnRoom_Back.Content = "Habitacion reservada";
                ListarHabitaciones();
            }
        }

        //Metodo para el cargue de las habitaciones en el programa
        private void CargarHabitaciones()
        {
            foreach (var habitacion in habitaciones)
            {
                if (habitacion.Usuario == null)
                {
                    var room = new Rooms();
                    room.setContext(habitacion, usuario, contenedorPersonal, 
                        labelTitulo, btnRoom_Back, rooms);
                    rooms.Add(room);
                }
            }
        }
        private void ListarHabitaciones()
        {
            foreach (var room in rooms)
            {
                contenedorPersonal.Children.Add(room);
            }
        }
    }
}
