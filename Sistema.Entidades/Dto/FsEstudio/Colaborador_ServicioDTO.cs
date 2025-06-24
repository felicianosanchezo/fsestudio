using Sistema.Entidades.Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades.Dto.FsEstudio
{
    public class Colaborador_ServicioDTO : ICloneable
    {

        public int IdServicio { get; set; } // Identificador único del servicio
        public string? Nombre { get; set; }

        public int IdServicio_Colaborador { get; set; } // Identificador único del servicio
        [Range(0, double.MaxValue, ErrorMessage = "El precio debe ser un valor positivo.")]
        public decimal Precio { get; set; }
        public decimal Precio_Ajustado { get; set; }
        public string? Unidad { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "La duración debe ser mayor que cero.")]
        public decimal Duracion { get; set; }
        [StringLength(500, ErrorMessage = "Las notas no pueden exceder los 500 caracteres.")]
        public string? Notas { get; set; } // Tiempo estimado de entrega del servicio
        public string? Email { get; set; } // Tiempo estimado de entrega del servicio
        public bool Estado { get; set; }  // Asegúrate de que Estado sea de tipo bool
        public DateTime FechaCreacion { get; set; } // Fecha de creación del servicio
        public DateTime FechaModificacion { get; set; } // Fecha de la última modificación del servicio
        public int IdUsuario { get; set; } // Relación con el usuario que creó o modificó el servicio
        public string? ArchivoUrl { get; set; } // URL de un archivo relacionado con el servicio
        public string? VideoUrl { get; set; } // URL de un archivo relacionado con el servicio
        public string? ImagenUrl1 { get; set; } // URL de la imagen en Azure Blob Storage
        public string? ImagenUrl2 { get; set; } // URL de la imagen en Azure Blob Storage
        public string? ImagenUrl3 { get; set; } // URL de la imagen en Azure Blob Storage
        public string? ImagenUrl4 { get; set; } // URL de la imagen en Azure Blob Storage
        public string? ImagenUrl5 { get; set; } // URL de la imagen en Azure Blob Storage
        public string? ImagenUrl6 { get; set; } // URL de la imagen en Azure Blob Storage
        public string? UrlPerfil { get; set; } // Tiempo estimado de entrega del servicio
        public string? Perfil { get; set; } // Tiempo estimado de entrega del servicio
        public int Calificaciones { get; set; } // Tiempo estimado de entrega del servicio





        public object Clone()
        {
            return MemberwiseClone(); // Crea una copia superficial
        }

    }
}
