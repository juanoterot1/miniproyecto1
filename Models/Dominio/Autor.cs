namespace Blog.Web.Models.Dominio
{
    public class Autor : Usuario
    {
        // Propiedades adicionales
        public string Nombre { get; set; }  // Nombre del autor
        public string Apellido { get; set; }  // Apellido del autor
        public List<Post> Posts { get; set; }  // Lista de posts creados por el autor

        // Constructor
        public Autor(string nombre, string apellido, string correo, string contrasena)
            : base(correo, contrasena)  // Llama al constructor de la clase base (Usuario)
        {
            Nombre = nombre;
            Apellido = apellido;
            Posts = new List<Post>();  // Inicializa la lista de posts
        }

        // Método para crear un nuevo post
        public void CrearPost(string titulo, string cuerpo)
        {
            var nuevoPost = new Post
            {
                Titulo = titulo,
                Cuerpo = cuerpo,
                FechaPublicacion = DateTime.Now,
                Estado = "Publicado",  // Asume que el post se publica inmediatamente
                Calificacion = 0.0
            };
            Posts.Add(nuevoPost);
        }

        // Método para editar un post existente
        public void EditarPost(Post post, string nuevoTitulo, string nuevoCuerpo)
        {
            if (Posts.Contains(post))
            {
                post.Titulo = nuevoTitulo;
                post.Cuerpo = nuevoCuerpo;
                post.FechaPublicacion = DateTime.Now;  // Actualiza la fecha de publicación
            }
        }

        // Método para eliminar un post
        public void EliminarPost(Post post)
        {
            if (Posts.Contains(post))
            {
                Posts.Remove(post);
            }
        }

        // Método para ver un post como lector
        public void VerPostComoLector(Post post)
        {
            // Lógica para ver el post como un lector
            Console.WriteLine($"Viendo el post '{post.Titulo}' como lector.");
        }

        // Método para comentar en un post
        public void ComentarEnPost(Post post, Comentario comentario)
        {
            if (Posts.Contains(post))
            {
                post.Comentarios.Add(comentario);
            }
        }
    }
}
