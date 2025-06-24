using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades.Dto.WMoveitDto
{
    public class WMoveitPaqueteCreateDto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int DuracionDias { get; set; }
        public decimal Precio { get; set; }
    }
}
