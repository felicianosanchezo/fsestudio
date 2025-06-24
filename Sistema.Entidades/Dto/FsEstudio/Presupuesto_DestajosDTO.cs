using System.ComponentModel.DataAnnotations;

namespace Sistema.Entidades.Dto.FsEstudio
{
    public class Presupuesto_DestajosDTO
    {
        public int IdProyecto { get; set; }

        [Required(ErrorMessage = "El ID del presupuesto es requerido.")]
        public int IdPresupuesto { get; set; }

        public int IdCatalogo { get; set; }

        [Required(ErrorMessage = "El ID del usuario es requerido.")]
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "La fecha es requerida.")]
        public DateTime Fecha { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "El número es requerido.")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "La descripción es requerida.")]
        [StringLength(200, ErrorMessage = "La descripción no puede tener más de 200 caracteres.")]
        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "La unidad es requerida.")]
        [StringLength(20, ErrorMessage = "La unidad no puede tener más de 20 caracteres.")]
        public string? Unidad { get; set; }

        [Required(ErrorMessage = "La cantidad es requerida.")]
        [Range(0, double.MaxValue, ErrorMessage = "La cantidad debe ser un valor positivo.")]
        public decimal Cantidad { get; set; }

        [Required(ErrorMessage = "El precio es requerido.")]
        [Range(0, double.MaxValue, ErrorMessage = "El precio debe ser un valor positivo.")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "La familia es requerida.")]
        [StringLength(100, ErrorMessage = "La familia no puede tener más de 100 caracteres.")]
        public string? Familia { get; set; }

        public int Tipo { get; set; }

        public virtual ICollection<Presupuesto_Destajos_DetalleDTO> Presupuesto_Destajos_Detalle { get; set; } = new List<Presupuesto_Destajos_DetalleDTO>();
    }
}
