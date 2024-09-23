using System;

namespace Blog.Web.Models.Dominio
{
    public class Comentario
    {
        public int Id { get; set; }  // Identificador único para el comentario
        public string Cuerpo { get; set; } = string.Empty;   // Contenido del comentario
        public DateTime Fecha { get; set; } = DateTime.Now; // Fecha en que se hizo el comentario
        public Usuario Autor { get; set; } = new Usuario();  // Relación con la clase Usuario (autor del comentario)

        // Nueva clave foránea para el Post al que pertenece este comentario
        public int PostId { get; set; }
        public Post Post { get; set; } = new Post();// Propiedad de navegación hacia el Post

        // Constructor sin parámetros requerido por EF Core
        public Comentario() { }

        // Constructor
        public Comentario(string cuerpo, Usuario autor)
        {
            Cuerpo = cuerpo;
            Fecha = DateTime.Now;  // Se asigna la fecha actual al crear el comentario
            Autor = autor;
        }

        // Método para editar el comentario
        public void EditarComentario(string nuevoCuerpo)
        {
            Cuerpo = nuevoCuerpo;
        }

        // Método para borrar el comentario
        public void BorrarComentario()
        {
            // Lógica para borrar el comentario
        }
    }
}
