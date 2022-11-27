namespace Entidades
{
    public class Habitacion
    {
        public uint Id { get; set; }
        public string Nombre { get; set; }
        public int NumHabitacion { get; set; }
        public string TipoHabitacion { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public Usuario Usuario { get; set; }

        public Habitacion(){}
        public Habitacion(string nombre, 
            int numHabitacion, string tipoHabitacion, 
            string descripcion, double precio, Usuario usuario)
        {
            Id = 0;
            Nombre = nombre;
            NumHabitacion = numHabitacion;
            TipoHabitacion = tipoHabitacion;
            Descripcion = descripcion;
            Precio = precio;
            Usuario = usuario;
        }
        public Habitacion(uint id, string nombre, 
            int numHabitacion, string tipoHabitacion, 
            string descripcion, double precio, Usuario usuario)
        {
            Id = id;
            Nombre = nombre;
            NumHabitacion = numHabitacion;
            TipoHabitacion = tipoHabitacion;
            Descripcion = descripcion;
            Precio = precio;
            Usuario = usuario;
        }
    }
}