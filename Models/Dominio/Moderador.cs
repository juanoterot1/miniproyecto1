namespace Blog.Web.Models.Dominio
{
    public class Moderador : Usuario
    {
        // Constructor
        public Moderador(string correo, string contrasena) : base(correo, contrasena)
        {
        }

        // Método para ver los posts en revisión
        public List<Post> VerPostRevisar()
        {
            // Lógica para obtener los posts que están en estado de "Revisión"
            return new List<Post>(); // Placeholder: Implementa la lógica para obtener los posts en revisión
        }

        // Método para aceptar un post
        public void AceptarPost(Post post)
        {
            if (post.Estado == "En Revisión")
            {
                post.Estado = "Publicado";
            }
        }

        // Método para censurar un post
        public void CensurarPost(Post post)
        {
            if (post.Estado != "Censurado")
            {
                post.Estado = "Censurado";
            }
        }

        // Método para buscar posts según un criterio
        public List<Post> BuscarPost(string criterio)
        {
            // Lógica para buscar posts según un criterio específico
            return new List<Post>(); // Placeholder: Implementa la lógica de búsqueda
        }

        // Método para ver posts con material beligerante
        public List<Post> VerPostConMaterialBeligerante()
        {
            // Lógica para obtener posts que contengan material beligerante
            return new List<Post>(); // Placeholder: Implementa la lógica para identificar material beligerante
        }
    }
}
