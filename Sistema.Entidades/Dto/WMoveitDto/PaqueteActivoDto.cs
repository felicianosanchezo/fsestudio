using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades.Dto.WMoveitDto
{
    public class PaqueteActivoDto
    {
        public string NombrePlan { get; set; }
        public int DuracionMeses { get; set; }
        public int NumeroSesiones { get; set; }
        public DateTime FechaActivacion { get; set; }
        public DateTime FechaVigencia { get; set; }
    }
}
