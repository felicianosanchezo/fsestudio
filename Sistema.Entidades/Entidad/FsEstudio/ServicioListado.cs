using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades.Entidad.FsEstudio
{
    public class ServicioListado
    {
        public int IdServicio { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string PortadaUrl { get; set; }
        public string Unidad { get; set; }
        public int Calificacion { get; set; }
        public decimal Precio { get; set; }
    }
}
