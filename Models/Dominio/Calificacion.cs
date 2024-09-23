namespace Blog.Web.Models.Dominio
{
    public class Calificacion
    {
        // Propiedades
        public int Id { get; set; } // Agregar clave primaria
        public float Valor { get; set; }  // Valor de la calificación
        public Lector Lector { get; set; }  // Referencia al lector que realizó la calificación

        // Constructor sin parámetros requerido por EF Core
        public Calificacion() { }

        // Constructor
        public Calificacion(float valor, Lector lector)
        {
            Valor = valor;
            Lector = lector;
        }

        // Método para modificar la calificación
        public void ModificarCalificacion(float nuevoValor)
        {
            Valor = nuevoValor;
        }
    }
}
