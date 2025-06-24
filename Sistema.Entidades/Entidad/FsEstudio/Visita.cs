using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades.Entidad.FsEstudio
{
    public class Visita
    {
        public string? Pagina { get; set; }
        public string? IdServicio { get; set; }
        public DateTime Timestamp { get; set; }
        public string? Usuario { get; set; }
        public string? IdUsuario { get; set; }
        public string? DeviceType { get; set; }
        public string? BrowserInfo { get; set; }
        public string? Referrer { get; set; }
        public string? Action { get; set; }
        public string? SessionStatus { get; set; }
        public string? IpAddress { get; set; }
        public string? Location { get; set; }


        public string? TrafficSource { get; set; } // utm_source
        public string? Medium { get; set; }         // utm_medium
        public string? Campaign { get; set; }       // utm_campaign
        public string? Term { get; set; }           // utm_term
        public string? Content { get; set; }        // utm_content





    }

}
