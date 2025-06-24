using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades.Entidad.FsEstudio
{
    public class Venta_Servicio
    {


        // Campos básicos de la venta
        public int? IdVenta_Servicio { get; set; } // Identificador único de la venta
        public int IdUsuarioComprador { get; set; } // Usuario que compra el servicio
        public string? NombreComprador { get; set; } // Estado de la venta (Pendiente, En Proceso, Completada, Cancelada)
        public string? TelefonoComprador { get; set; } // Estado de la venta (Pendiente, En Proceso, Completada, Cancelada)
        public string? Email_Cliente { get; set; }
        public int IdServicio { get; set; } // Servicio que se está vendiendo
        public string? NombreServicio { get; set; } // Estado de la venta (Pendiente, En Proceso, Completada, Cancelada)
        public int IdServicio_Colaborador { get; set; } // Servicio que se está vendiendo
        public int IdUsuarioColaborador { get; set; } // Usuario que ofrece el servicio
        public string? NombreColaborador { get; set; } // Estado de la venta (Pendiente, En Proceso, Completada, Cancelada)
        public int Cantidad { get; set; } // Cantidad de servicios adquiridos
        public string? Unidad { get; set; } // Estado de la venta (Pendiente, En Proceso, Completada, Cancelada)
        public int Revision { get; set; } // Cantidad de servicios adquiridos
        public decimal Precio { get; set; } // Precio unitario del servicio
        public decimal Tiempo { get; set; } // Tiempo estimado del servicio (horas, días, etc.)
        public decimal Importe { get; set; } // Costo del servicio para el colaborador
        public decimal Total { get; set; } // Total calculado de la venta
        public int IdCupon { get; set; } // Usuario que ofrece el servicio
        // Campos adicionales
        public DateTime FechaCreacion { get; set; } // Fecha de creación de la venta
        public DateTime? FechaEntregaEstimada { get; set; } // Fecha estimada de entrega del servicio
        public string? Estado { get; set; } // Estado de la venta (Pendiente, En Proceso, Completada, Cancelada)
        public string? MetodoPago { get; set; } // Método de pago utilizado
        public bool PagoRealizado { get; set; } // Indica si el pago ha sido completado
        public DateTime? FechaPago { get; set; } // Fecha en que se realizó el pago
        public string? ReferenciaPago { get; set; } // Referencia de la transacción de pago
        public decimal Descuento { get; set; } // Descuento aplicado a la venta
        public decimal Impuestos { get; set; } // Impuestos aplicados
        public string? DescripcionServicio { get; set; } // Descripción del servicio adquirido
        public string? Observaciones { get; set; } // Comentarios o notas adicionales de la venta
        public DateTime? FechaModificacion { get; set; } // Última modificación de la venta
        public int? UsuarioModificacion { get; set; } // Usuario que modificó la venta
        public string? UbicacionServicio { get; set; } // Ubicación física del servicio (si aplica)

        // Campos relacionados con la calificación del servicio
        public int? Calificacion { get; set; } // Calificación dada por el comprador
        public string? Comentarios { get; set; } // Comentarios del comprador sobre el servicio

        // Logística de entrega
        public string? MetodoEntrega { get; set; } // Método de entrega (en línea, presencial, etc.)
                                                   // Logística de entrega
        public string? ClientSecret { get; set; } // Este es el token de Stripe para confirmar el pago
        public string? IdTransaccion { get; set; } // ID de la transacción de Stripe (opcional si necesitas guardarlo)

        //Terminos y condiciones
        public bool TerminosAceptados { get; set; }
        public string? VersionTerminosServicio { get; set; }
        public string? EspecificacionesAceptados { get; set; }
        public string? EntregablesAceptados { get; set; }
        public string? RequisitosAceptados { get; set; }


        public string? NumeroOrden { get; set; } // Campo para el número de orden



        public decimal Precio_Ajustado { get; set; } // Precio unitario del servicio
        public decimal Antcipo { get; set; } // Precio unitario del servicio
        public decimal Porcentaje_Anticipo { get; set; } // Precio unitario del servicio
        public decimal Finiquito { get; set; } // Precio unitario del servicio
        public decimal Porcentaje_Finiquito { get; set; } // Precio unitario del servicio
        public decimal Pago_Final { get; set; } // Precio unitario del servicio







    }
}
