using System.ComponentModel.DataAnnotations;

namespace Sistema.Entidades.Dto.FsEstudio
{
    public class Ingreso_DetalleDTO
    {
        public int IdIngresoDetalle { get; set; }
        public int IdIngreso { get; set; }

        [Required(ErrorMessage = "El total es obligatorio.")]
        [Range(double.MinValue, double.MaxValue, ErrorMessage = "El total debe ser un número válido.")]
        public decimal Total { get; set; }

        [Required(ErrorMessage = "El ID de la cuenta es obligatorio.")]
        public int IdCuenta { get; set; }

        public string? Cuenta { get; set; }

        [Required(ErrorMessage = "El porcentaje es obligatorio.")]
        [Range(0, 100, ErrorMessage = "El porcentaje debe estar entre 0 y 100.")]
        public decimal Porcentaje { get; set; }
    }
}
