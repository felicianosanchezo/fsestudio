using System.ComponentModel.DataAnnotations;

namespace Sistema.Entidades.Dto.FsEstudio
{
    public class MaterialDTO
    {
        public int IdMaterial { get; set; }

        [Required(ErrorMessage = "La clave es requerida.")]
        [StringLength(50, ErrorMessage = "La clave no puede tener más de 50 caracteres.")]
        public string? Clave { get; set; }

        [Required(ErrorMessage = "El tipo es requerido.")]
        public string? Tipo { get; set; }


        [Required(ErrorMessage = "La categoría es requerida.")]
        public string? Categoria { get; set; }

        [Required(ErrorMessage = "La descripción es requerida.")]
        [StringLength(200, ErrorMessage = "La descripción no puede tener más de 200 caracteres.")]
        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "La marca es requerida.")]
        [StringLength(100, ErrorMessage = "La marca no puede tener más de 100 caracteres.")]
        public string? Marca { get; set; }

        [Required(ErrorMessage = "La unidad es requerida.")]
        [StringLength(20, ErrorMessage = "La unidad no puede tener más de 20 caracteres.")]
        public string? Unidad { get; set; }

        [Required(ErrorMessage = "El precio es requerido.")]
        [Range(0, double.MaxValue, ErrorMessage = "El precio debe ser un valor positivo.")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "La fecha es requerida.")]
        public DateTime Fecha { get; set; } = DateTime.Now;


        public bool Iva { get; set; } = true;

        public bool Estado { get; set; } = true;

        [Required(ErrorMessage = "El ID del usuario es requerido.")]

        public int IdUsuario { get; set; }


        public string? Usuario { get; set; }

















    }
}
