namespace Entidades
{
    public class Habitacion
    {
        public uint Id { get; set; }
        public int NumHabitacion { get; set; }
        public string TipoHabitacion { get; set; }
        public double Precio { get; set; }

        public Habitacion()
        {
            
        }

        public Habitacion(uint id, int numHabitacion, string tipoHabitacion)
        {
            Id = id;
            NumHabitacion = numHabitacion;
            TipoHabitacion = tipoHabitacion;
        }
    }
}