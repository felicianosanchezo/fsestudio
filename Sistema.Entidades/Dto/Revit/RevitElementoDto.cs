using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades.Dto.Revit
{
    public class RevitElementoDto
    {
        public int IdProyecto { get; set; }
        public int IdElemento { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public double Area { get; set; }
        public double Volumen { get; set; }
        public string Material { get; set; }
        public double CostoUnitario { get; set; }
        public double CostoTotal { get; set; } // 🔹 Agregar esta propiedad

    }
}
