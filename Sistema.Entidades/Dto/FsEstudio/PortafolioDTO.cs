using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades.Dto.FsEstudio
{
    public class PortafolioDTO
    {
        public int IdPortafolio { get; set; } // Por si quieres usarlo después en editar/eliminar

        public string Nombre { get; set; } = string.Empty;
        public string? Descripcion { get; set; }
        public string? Areas{ get; set; }
        public string? Categoria { get; set; }
        public string? Ubicacion { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Today;
        public decimal SuperficieConstruidaM2 { get; set; }
        public decimal SuperficieTerrenoM2 { get; set; }
        public bool FueConstruido { get; set; }

        public string? PortadaUrl { get; set; }

        public string? Imagen1Url { get; set; }
        public string? Imagen2Url { get; set; }
        public string? Imagen3Url { get; set; }
        public string? Imagen4Url { get; set; }
        public string? Imagen5Url { get; set; }
        public string? Imagen6Url { get; set; }

        public bool Activo { get; set; } = true;
        public int? Orden { get; set; }
    }
}
