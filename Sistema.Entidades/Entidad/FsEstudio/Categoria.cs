namespace Sistema.Entidades.Entidad.FsEstudio
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool? Estado { get; set; }
        public string Operacion { get; set; }
        public int? IdUsuario { get; set; }
    }
}
