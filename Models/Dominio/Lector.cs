namespace Blog.Web.Models.Dominio
{
    public class Lector : Usuario
    {
        // Propiedades adicionales
        public List<Calificacion> Calificaciones { get; set; }  // Calificaciones hechas por el lector
        public List<Post> MeGustaPosts { get; set; }  // Posts a los que el lector ha dado "Me gusta"

        // Constructor
        public Lector(string correo, string contrasena) : base(correo, contrasena)
        {
            Calificaciones = new List<Calificacion>();
            MeGustaPosts = new List<Post>();  // Inicializar la lista de "Me gusta"
        }

        // Método para calificar un post
        public void CalificarPost(Post post, float calificacion)
        {
            var nuevaCalificacion = new Calificacion(calificacion, this);
            Calificaciones.Add(nuevaCalificacion);
        }


        // Método para agregar un "Me gusta" a un post
        public void AgregarMeGusta(Post post)
        {
            if (!MeGustaPosts.Contains(post))
            {
                MeGustaPosts.Add(post);
            }
        }

        // Método para quitar un "Me gusta" de un post
        public void QuitarMeGusta(Post post)
        {
            if (MeGustaPosts.Contains(post))
            {
                MeGustaPosts.Remove(post);
            }
        }

        // Método para comentar en un post
        public void ComentarPost(Post post, string comentario)
        {
            var nuevoComentario = new Comentario(comentario, this);
            post.Comentarios.Add(nuevoComentario);
        }

        // Método para buscar posts por un criterio (por ejemplo, por título)
        public List<Post> BuscarPost(string criterio)
        {
            // Aquí implementarías la lógica para buscar posts según el criterio
            // Este es solo un ejemplo básico
            return new List<Post>();  // Placeholder: deberías implementar la búsqueda real
        }
    }
}
