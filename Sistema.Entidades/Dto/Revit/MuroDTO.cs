using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades.Dto.Revit
{
    public class MuroDTO
    {
        public int IdElemento { get; set; }
        public string Ejes { get; set; }
        public string EntreEjes1 { get; set; }
        public string EntreEjes2 { get; set; }
        public string Familia { get; set; }
        public string Tipo { get; set; }
        public double Longitud { get; set; }
        public double AlturaDesconectada { get; set; }
        public string RestriccionBase { get; set; }
        public string Usuario { get; set; }
        public string Empresa { get; set; }
        public string Proyecto { get; set; }
    }
}
