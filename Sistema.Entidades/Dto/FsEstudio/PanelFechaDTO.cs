namespace Sistema.Entidades.Dto.FsEstudio
{
    public class PanelFechaDTO
    {
        public string? Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public decimal Total { get; set; }
        public string? Cartera { get; set; }
        public string? Cuenta { get; set; }
        public string? Categoria { get; set; }
        public string? Concepto { get; set; }
        public decimal Porcentaje { get; set; }
    }
}
