namespace Sistema.Entidades.Entidad.FsEstudio
{


    public class Ingreso
    {
        public int IdIngreso { get; set; }

        public int IdUsuario { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        public decimal Total { get; set; }

        public int IdCartera { get; set; }

        public int IdCategoria { get; set; }

        public string? Concepto { get; set; }

        public string? Categoria { get; set; }
        public string? Cartera { get; set; }


        public virtual ICollection<Ingreso_Detalle> IngresoDetalle { get; set; } = new List<Ingreso_Detalle>();
    }

}
