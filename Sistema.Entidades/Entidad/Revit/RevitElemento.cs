using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades.Entidad.Revit
{
    public class RevitElemento
    {
        public int IdProyecto { get; set; }
        public int IdElemento{ get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public double Area { get; set; }
        public double Volumen { get; set; }
        public string Material { get; set; }
        public double CostoUnitario { get; set; }
        public double CostoTotal { get; set; } // 📌 Agregar si falta
    }
}
