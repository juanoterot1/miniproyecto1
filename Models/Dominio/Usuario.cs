namespace Blog.Web.Models.Dominio
{
    public class Usuario
    {
        public int Id { get; set; }  // Clave primaria
        public string Correo { get; set; }  // Email del usuario
        public string Contrasena { get; set; }  // Contraseña del usuario

        // Constructor sin parámetros requerido por EF Core
        public Usuario() { }

        // Constructor
        public Usuario(string correo, string contrasena)
        {
            Correo = correo;
            Contrasena = contrasena;
        }

        // Métodos según el diagrama de clases
        public void Registrarse(string correo, string contrasena)
        {
            // Lógica para registrar al usuario
        }

        public bool IniciarSesion(string correo, string contrasena)
        {
            // Lógica para iniciar sesión
            return true;  // Esto es solo un placeholder, deberías implementar la lógica real
        }
    }
}
