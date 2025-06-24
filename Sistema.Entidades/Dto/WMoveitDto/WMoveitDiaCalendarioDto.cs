using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades.Dto.WMoveitDto
{
  public class WMoveitDiaCalendarioDto
    {
        public DateTime Fecha { get; set; } // La fecha del día
        public bool EsDelMes { get; set; } // Indica si el día pertenece al mes actual
        public List<WMoveitHorarioDto> Horarios { get; set; } = new(); // Horarios disponibles para ese día
    }
}
