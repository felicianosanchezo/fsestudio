using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades.Dto.WMoveitDto
{
    public class WMoveitUsuarioPlanesDto
    {
        public int IdUsuario { get; set; }
        public int IdPaquete { get; set; }
        public string Nombre { get; set; }
        public string Nombre_Paquete { get; set; }
        public decimal? Precio { get; set; }
        public DateTime? FechaActivacion { get; set; }
        public DateTime? FechaVigencia { get; set; }
        public TimeSpan? HoraActivacion { get; set; }
        public TimeSpan? HoraFinalizacion { get; set; }
        public int Numero_Sesiones { get; set; }
        public int Ajuste_Manual { get; set; }
        public int ClasesReservadas { get; set; }
        public int ClasesCanceladas { get; set; }
        public int ClasesPendientes { get; set; }
        public int ClasesTerminadas { get; set; }
        public string EstadoPaquete { get; set; }
        public int IdUsuarioPaquete { get; set; }
    }
}
