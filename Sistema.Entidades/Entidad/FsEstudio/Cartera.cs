namespace Sistema.Entidades.Entidad.FsEstudio
{
    public class Cartera
    {
        public int IdCartera { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool? Estado { get; set; }
        public int? Orden { get; set; }
        public int? IdUsuario { get; set; }
        public string Tipo { get; set; }
    }
}
