using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades.Dto.FsEstudio
{
    public class ErrorDTO
    {
        public string? Mensaje { get; set; }         // Mensaje de la excepción
        public string? Detalles { get; set; }        // Detalles o StackTrace del error
        public DateTime Fecha { get; set; }         // Fecha del error
        public string? MensajePersonalizado { get; set; }  // Mensaje personalizado adicional
    }

}
