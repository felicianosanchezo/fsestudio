using Sistema.Entidades.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades.Entidad.FsEstudio
{
    public class Colaborador_Servicio
    {

        public int IdServicio { get; set; } // Identificador único del servicio
        public string? Nombre { get; set; }
        public int IdServicio_Colaborador { get; set; } // Identificador único del servicio
        public decimal Precio { get; set; } // Precio del servicio
        public string? Unidad { get; set; } // Precio del servicio
        public decimal Duracion { get; set; } // Tiempo estimado de entrega del servicio
        public string? Notas { get; set; } // Tiempo estimado de entrega del servicio
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

        public string? Email { get; set; } // Tiempo estimado de entrega del servicio

    }
}
