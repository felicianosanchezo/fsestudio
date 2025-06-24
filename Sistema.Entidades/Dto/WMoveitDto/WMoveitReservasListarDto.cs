using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades.Dto.WMoveitDto
{
    public class WMoveitReservasListarDto
    {
        public int IdReserva { get; set; }
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public int IdClase { get; set; }
        public string NombreClase { get; set; }
        public DateTime FechaClase { get; set; }
        public TimeSpan HoraClase { get; set; }
        public DateTime FechaReserva { get; set; }
        public int Estado { get; set; }
        public int? IdUsuarioPaquete { get; set; }
    }
}
