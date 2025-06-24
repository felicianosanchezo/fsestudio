using System.ComponentModel.DataAnnotations;

namespace Sistema.Entidades.Dto.FsEstudio
{
    public class Presupuesto_Destajos_DetalleDTO
    {

        public int IdPresupuesto_Destajos_Detalle { get; set; }

        [Required(ErrorMessage = "El número es requerido.")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "La descripción es requerida.")]
        [StringLength(200, ErrorMessage = "La descripción no puede tener más de 200 caracteres.")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "La unidad es requerida.")]
        [StringLength(20, ErrorMessage = "La unidad no puede tener más de 20 caracteres.")]
        public string Unidad { get; set; }

        [Required(ErrorMessage = "La cantidad es requerida.")]
        [Range(0, double.MaxValue, ErrorMessage = "La cantidad debe ser un valor positivo.")]
        public decimal Cantidad { get; set; }

        [Required(ErrorMessage = "El precio es requerido.")]
        [Range(0, double.MaxValue, ErrorMessage = "El precio debe ser un valor positivo.")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "La familia es requerida.")]
        [StringLength(100, ErrorMessage = "La familia no puede tener más de 100 caracteres.")]
        public string? Familia { get; set; }

        [Required(ErrorMessage = "El tipo es requerido.")]
        public int Tipo { get; set; }








    }
}
