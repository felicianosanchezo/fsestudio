using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades.Dto.FsEstudio
{
    public class CuponDTO
    {
        public int Id { get; set; } // ID único del cupón
        public string? Codigo { get; set; } // Código del cupón (p.ej., "DESCUENTO2024")
        public decimal Descuento { get; set; } // Porcentaje o cantidad de descuento
        public DateTime FechaInicio { get; set; } // Fecha desde cuando es válido el cupón
        public DateTime FechaExpiracion { get; set; } // Fecha de expiración del cupón
        public bool EsActivo { get; set; } // Indica si el cupón está activo o no
        public int UsoMaximo { get; set; } // Cantidad máxima de veces que puede usarse
        public int UsoActual { get; set; } // Cantidad de veces que ya ha sido usado
        public string? Descripcion { get; set; } // Descripción del cupón
        public int? IdVenta_Servicio { get; set; } // Relación con una entidad de Venta o Servicio (opcional)
    }
}
