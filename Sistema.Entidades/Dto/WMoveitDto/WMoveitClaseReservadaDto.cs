using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades.Dto.WMoveitDto
{
    public class WMoveitClaseReservadaDto
    {

        public int IdClase { get; set; }        // Identificador único de la clase reservada
        public string Dia { get; set; }         // Día de la clase reservada
        public string Hora { get; set; }        // Hora de la clase reservada
        public int UsuarioId { get; set; }      // ID del usuario que reservó
        public int IdPaquete { get; set; }      // ID del paquete al que pertenece la clase
        public int ClasesRestantes { get; set; } // Número de clases restantes en el paquete


    }
}
