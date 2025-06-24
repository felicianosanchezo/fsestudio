using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades.Entidad.FsEstudio
{
    public class Cupon
    {
        public int Id { get; set; } // ID único del cupón
        public string Codigo { get; set; } // Código del cupón, por ejemplo: "DESCUENTO10"
        public decimal Descuento { get; set; } // Descuento en porcentaje o cantidad fija
        public DateTime FechaInicio { get; set; } // Fecha de inicio de validez del cupón
        public DateTime FechaExpiracion { get; set; } // Fecha de expiración del cupón
        public bool EsActivo { get; set; } // Indica si el cupón está activo
        public int UsoMaximo { get; set; } // Cantidad máxima de veces que puede usarse el cupón
        public int UsoActual { get; set; } // Cantidad de veces que el cupón ha sido usado
        public string Descripcion { get; set; } // Descripción del cupón
        public bool EsPorcentaje { get; set; } // Si es true, el descuento es en porcentaje; si es false, es un valor fijo
        public int? IdVenta_Servicio { get; set; } // Relación con una entidad de Venta o Servicio (opcional)
    }

}
