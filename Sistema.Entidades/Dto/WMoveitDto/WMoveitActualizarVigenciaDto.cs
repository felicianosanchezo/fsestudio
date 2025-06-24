using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades.Dto.WMoveitDto
{
    public class WMoveitActualizarVigenciaDto
    {
        public int IdUsuario { get; set; }
        public DateTime FechaActivacion { get; set; }
        public int DuracionMeses { get; set; }
    }
}
