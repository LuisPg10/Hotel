namespace Entidades
{
    public class Habitacion
    {
        public int Id { get; set; }
        public int NumHabitacion { get; set; }
        public string TipoHabitacion { get; set; }
        public double Precio { get; set; }

        public Habitacion()
        {
            
        }

        public Habitacion(int id, int numHabitacion, string tipoHabitacion)
        {
            Id = id;
            NumHabitacion = numHabitacion;
            TipoHabitacion = tipoHabitacion;
        }
    }
}