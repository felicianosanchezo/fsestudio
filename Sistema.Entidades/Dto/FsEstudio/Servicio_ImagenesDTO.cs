using Sistema.Entidades.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades.Dto.FsEstudio
{
    public class Servicio_ImagenesDTO
    {
        public int Id { get; set; } // Id único de la imagen
        public string Url { get; set; } // URL de la imagen en Azure Blob Storage
        public int IdServicio { get; set; } // Id del servicio al que pertenece la imagen
        public int OrdenVisualizacion { get; set; } // Orden de visualización para el front-end
        public DateTime FechaSubida { get; set; } // Fecha de subida de la imagen
        public int IdUsuario { get; set; } // Id del usuario que subió la imagen


    }

}




