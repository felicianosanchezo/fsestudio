using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades.Entidad.WMoveit
{
    public class WMoveitUsuarioReservado
    {
        public int IdReserva { get; set; }
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Correo { get; set; }
        public DateTime FechaReserva { get; set; }
        public int Estado { get; set; } // 1 = Activo
    }
}
