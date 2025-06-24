using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades.Entidad.WMoveit
{


        public class WMoveitPaquete
        {
            public int IdPaquete { get; set; }
            public string Nombre { get; set; }
            public string Descripcion { get; set; }
            public int NumeroSesiones { get; set; }
            public decimal Precio { get; set; }
            public DateTime FechaCreacion { get; set; }
        }
    
}
