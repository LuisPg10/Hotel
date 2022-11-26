namespace Entidades
{
    public class Habitacion
    {
        public uint Id { get; set; }
        public int NumHabitacion { get; set; }
        public string TipoHabitacion { get; set; }
        public double Precio { get; set; }
        public Usuario Usuario { get; set; }

        public Habitacion(){}
        public Habitacion(int numHabitacion, string tipoHabitacion, double precio, Usuario usuario)
        {
            NumHabitacion = numHabitacion;
            TipoHabitacion = tipoHabitacion;
            Precio = precio;
            Usuario = usuario;
        }
        public Habitacion(uint id, int numHabitacion, string tipoHabitacion, double precio, Usuario usuario)
        {
            Id = id;
            NumHabitacion = numHabitacion;
            TipoHabitacion = tipoHabitacion;
            Precio = precio;
            Usuario = usuario;
        }
    }
}