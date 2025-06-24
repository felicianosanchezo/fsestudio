namespace Sistema.Entidades.Entidad.FsEstudio
{
    public class Gasto
    {

        public int IdGasto { get; set; }

        public int IdUsuario { get; set; }

        public DateTime Fecha { get; set; }

        public decimal Total { get; set; }

        public int IdCartera { get; set; }

        public int IdCuenta { get; set; }

        public int IdCategoria { get; set; }

        public string? Concepto { get; set; }

        public string? Cuenta { get; set; }
        public string? Categoria { get; set; }
        public string? Cartera { get; set; }

    }
}
