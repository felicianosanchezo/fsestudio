namespace Sistema.Entidades.Entidad.FsEstudio
{
    public class Ingreso_Detalle
    {
        public int IdIngresoDetalle { get; set; }
        public int IdIngreso { get; set; }

        public decimal Total { get; set; }

        public int IdCuenta { get; set; }

        public string? Cuenta { get; set; }

        public decimal Porcentaje { get; set; }
    }
}
