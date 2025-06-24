using System.ComponentModel.DataAnnotations;

namespace Sistema.Entidades.Dto.FsEstudio
{
    public class GastoDTO
    {

        public int IdGasto { get; set; }

        [Required(ErrorMessage = "El ID del usuario es obligatorio.")]
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "La fecha es obligatoria.")]
        public DateTime Fecha { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "El total es obligatorio.")]
        [Range(double.MinValue, double.MaxValue, ErrorMessage = "El total debe ser un número válido.")]
        public decimal Total { get; set; }

        [Required(ErrorMessage = "El ID de la cartera es obligatorio.")]
        public int IdCartera { get; set; }

        [Required(ErrorMessage = "El ID de la cuenta es obligatorio.")]
        public int IdCuenta { get; set; }

        [Required(ErrorMessage = "El ID de la categoría es obligatorio.")]
        public int IdCategoria { get; set; }

        [Required(ErrorMessage = "El concepto es obligatorio.")]
        [StringLength(250, ErrorMessage = "El concepto no puede tener más de 100 caracteres.")]
        public string? Concepto { get; set; }


        public string? Cuenta { get; set; }
        public string? Categoria { get; set; }
        public string? Cartera { get; set; }

    }
}
