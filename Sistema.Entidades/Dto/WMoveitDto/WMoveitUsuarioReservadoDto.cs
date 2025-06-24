using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades.Dto.WMoveitDto
{
    public class WMoveitUsuarioReservadoDto
    {
        public int IdReserva { get; set; }
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Correo { get; set; }
        public DateTime FechaReserva { get; set; }
        public int Estado { get; set; } // 1 = Activo


    }

}
