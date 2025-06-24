namespace Sistema.Entidades.Dto.FsEstudio
{
    public class CuentaDTO
    {
        public int IdCuenta { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public bool? Estado { get; set; }
        public decimal Porcentaje { get; set; }
        public int? Orden { get; set; }
        public int? IdUsuario { get; set; }
        public bool? Panel { get; set; }
    }
}
