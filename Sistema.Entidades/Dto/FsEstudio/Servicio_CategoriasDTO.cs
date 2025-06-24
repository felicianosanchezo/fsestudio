using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades.Dto.FsEstudio
{
    public class Servicio_CategoriaDTO
    {
        public int IdCategoria { get; set; } // Identificador único de la categoría
        public string Nombre { get; set; } // Nombre de la categoría
        public string Descripcion { get; set; } // Descripción de la categoría
        public int IdUsuario { get; set; } // Identificador del usuario que creó la categoría
    }
}
