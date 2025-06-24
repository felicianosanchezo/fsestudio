using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades.Entidad.FsEstudio
{
   public class ServicioNivelDetalle
    {

        public int IdNivelDetalle { get; set; }
        public int IdServicio { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public string? Unidad { get; set; }
        public decimal? Precio { get; set; }
        public int? Tiempo { get; set; }
        public string? Checklist { get; set; }
        public bool Activo { get; set; } = true;
        public DateTime FechaCreacion { get; set; } = DateTime.Now;


    }
}
