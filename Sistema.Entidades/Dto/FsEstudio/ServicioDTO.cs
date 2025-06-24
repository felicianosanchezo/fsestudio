using System;

namespace Sistema.Entidades.Dto.FsEstudio
{
    public class ServicioDTO
    {
        public int IdServicio { get; set; } // Identificador único del servicio

        public string? Nombre { get; set; } // Nombre del servicio

        public string? Descripcion { get; set; } // Descripción detallada del servicio

        public string? Categoria { get; set; } // Categoría del servicio


        public string? Especificaciones { get; set; } // Especificaciones adicionales del servicio

        public bool Estado { get; set; }  // Estado del servicio como booleano

        public DateTime? FechaCreacion { get; set; } // Fecha de creación del servicio

        public DateTime? FechaModificacion { get; set; } // Fecha de la última modificación del servicio

        public int IdUsuario { get; set; } // Relación con el usuario que creó o modificó el servicio

        public string? Usuario { get; set; } // Nombre del usuario que creó o modificó el servicio

        public string? PortadaUrl { get; set; } // URL de la imagen de portada del servicio

        public string? Unidad { get; set; } // Unidad del servicio (ej. horas, días)

        public string? Requisitos_Cliente { get; set; } // Requisitos que el cliente debe cumplir

        public string? Entregables { get; set; } // Descripción de los entregables del servicio

        public string? Etiquetas { get; set; } // Etiquetas para clasificar el servicio

        public string? Requisitos_Colaborador { get; set; } // Requisitos que el colaborador debe cumplir

        public string? Dirigido { get; set; } // Público objetivo al que se dirige el servicio

        public string? Garantia { get; set; } // Información sobre garantía del servicio


        public int Calificacion { get; set; } // Información sobre garantía del servicio

    }
}
