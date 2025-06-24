using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades.Entidad.FsEstudio
{
    public class Venta_Servicio_Carrito
    {
        public int IdCarrito { get; set; } // Identificador único del registro en el carrito
        public int IdUsuario { get; set; } // ID del usuario que agrega el servicio al carrito
        public int IdServicio { get; set; } // ID del servicio que se agrega al carrito
        public int IdColaborador { get; set; } // ID del servicio que se agrega al carrito
        public int IdColaborador_Servico { get; set; } // ID del servicio que se agrega al carrito
        public string? NombreServicio { get; set; } // Nombre del servicio
        public int Cantidad { get; set; } // Cantidad de servicios en el carrito
        public decimal Precio { get; set; } // Precio unitario del servicio
        public decimal Importe { get; set; } // Precio * Cantidad
        public DateTime FechaAgregado { get; set; } // Fecha en que se agregó al carrito
        public string Estado { get; set; } = "En Carrito"; // Estado del registro (En Carrito, Comprado, etc.)

        public int Revision { get; set; } // Cantidad de servicios adquiridos
        public decimal Tiempo { get; set; } // Tiempo estimado del servicio (horas, días, etc.)

    }
}
