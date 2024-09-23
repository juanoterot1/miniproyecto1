using System;
using System.Collections.Generic;

namespace Blog.Web.Models.Dominio
{
    public class Post
    {
        // Propiedades básicas
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Cuerpo { get; set; } = string.Empty;
        public DateTime FechaPublicacion { get; set; }
        public string Estado { get; set; } = "En Revisión";
        public double Calificacion { get; set; }

        // Relaciones
        public List<Comentario> Comentarios { get; set; }

        // Constructor
        public Post()
        {
            Comentarios = new List<Comentario>();
        }

        // Métodos adicionales si son necesarios
    }
}
