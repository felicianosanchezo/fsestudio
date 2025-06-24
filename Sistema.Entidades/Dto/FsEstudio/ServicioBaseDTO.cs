using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations;

namespace Sistema.Entidades.Dto.FsEstudio
{

    public class ServicioBaseDTO
    {
        public int IdServicio { get; set; }

        [Required(ErrorMessage = "El código es obligatorio.")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; }

        public string? Descripcion { get; set; }

        public string? Nivel { get; set; }

        [Required(ErrorMessage = "El capítulo es obligatorio.")]
        public string Capitulo { get; set; }

        [Required(ErrorMessage = "La categoría es obligatoria.")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "El tipo es obligatorio.")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "La unidad es obligatoria.")]
        public string Unidad { get; set; }

        public bool AplicaPorM2 { get; set; }
        public bool Activo { get; set; }

        public string? PortadaUrl { get; set; } // Imagen opcional

        [Required(ErrorMessage = "La fecha es obligatoria.")]
        public DateTime Fecha { get; set; } = DateTime.Today;
    }

}
