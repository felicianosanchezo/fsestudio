using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades.Entidad.WMoveit
{
    public class WMoveitHorario
    {
        public int IdHorario { get; set; } // Identificador único del horario
        public string? Dia { get; set; }    // Día de la clase (Ej: "Lunes")
        public TimeSpan Hora { get; set; } // Hora de la clase (Ej: 10:00 AM)
        public string? Clase { get; set; }  // Nombre de la clase (Ej: "JUMP", "FIT")
        public int IdUsuario { get; set; } // Identificador del maestro que imparte la clase
        public DateTime Fecha { get; set; } // Fecha específica del horario (Ej: "2025-01-15")
        public string? Nombre { get; set; }  // Nombre de la clase (Ej: "JUMP", "FIT")
        public int Cupo { get; set; }  // Nombre de la clase (Ej: "JUMP", "FIT")
        public int CupoDisponible { get; set; }  // Nombre de la clase (Ej: "JUMP", "FIT")
        public bool Activo { get; set; }
        public int UsuariosReservados { get; set; } // Número de usuarios reservados
    }

}

