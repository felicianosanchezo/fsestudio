using Sistema.Entidades.Dto;

namespace Sistema.Entidades.Entidad.FsEstudio
{
    public class LoginUsuario
    {
        public string IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Email { get; set; }
        public string Nombre { get; set; }
        public string Nombre_Publico { get; set; }
        public string Rol { get; set; }
        public string Token { get; set; }
    }
}
