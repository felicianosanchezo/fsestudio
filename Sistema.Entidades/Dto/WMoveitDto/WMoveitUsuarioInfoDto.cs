using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades.Dto.WMoveitDto
{
    public class WMoveitUsuarioInfoDto
    {
        public string Nombre { get; set; }
        public string PaqueteNombre { get; set; }
        public int ClasesAsignadas { get; set; }
        public int ClasesReservadas { get; set; }
        public int ClasesPendientes { get; set; }
        public int ClasesCanceladas { get; set; }
        public string EstadoUsuario { get; set; }
        public int IdUsuarioPaquete{ get; set; }

        public DateTime? FechaActivacion { get; set; }
        public DateTime? FechaVigencia { get; set; }
    }
}
