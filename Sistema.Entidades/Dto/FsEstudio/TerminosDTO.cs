using System;
using System.Collections.Generic;

namespace Sistema.Entidades.Dto.FsEstudio
{
    public class TerminosDto
    {
        public string Titulo { get; set; }
        public string Especificaciones { get; set; }
        public string Version { get; set; }
        public DateTime FechaTerminos { get; set; } // Nueva propiedad para la fecha

        public TerminosDto(string titulo, string especificaciones, string version, DateTime fechaTerminos)
        {
            Titulo = titulo;
            Especificaciones = especificaciones;
            Version = version;
            FechaTerminos = fechaTerminos;
        }
    }

    public static class TerminosService
    {
        public static List<TerminosDto> ObtenerTerminos()
        {
            return new List<TerminosDto>
            {
                new TerminosDto(
                    "Términos y Condiciones Generales",
                    "Introducción: Estos términos y condiciones rigen el uso de nuestro sitio web y los servicios ofrecidos. Al acceder o contratar nuestros servicios, usted acepta cumplir con estos términos.|" +
                    
                    // Otros detalles de términos y condiciones
                    "Métodos de Compra: Aceptamos pagos a través de transferencia bancaria, tarjeta de crédito, débito y otros métodos especificados en la página de pagos. Los pagos deben ser completados en su totalidad antes de la entrega del producto o servicio.|" +
                    "Confirmación de Pedido: Una vez que el pago sea confirmado, recibirá una notificación de confirmación del pedido por correo electrónico. Es responsabilidad del cliente verificar los detalles de su pedido.|" +
                    "Política de Cancelación y Reembolso: Las cancelaciones deben realizarse dentro de las primeras 24 horas después de la compra. Si se autoriza un reembolso, este se procesará en un plazo de 5 a 7 días hábiles. Los reembolsos no aplican para servicios ya ejecutados.|" +

                    "Especificaciones para el Cliente: Para garantizar un servicio efectivo, el cliente debe proporcionar toda la información requerida para el proyecto en el tiempo acordado. Esto incluye planos, ideas, imágenes y cualquier documentación adicional.|" +
                    "Responsabilidades del Cliente: El cliente es responsable de la veracidad y precisión de toda la información proporcionada. Cualquier retraso o falta de información puede afectar los plazos de entrega y la calidad del servicio.|" +
                    "Revisión de Materiales: El cliente tiene derecho a revisar los materiales y a solicitar cambios dentro del marco del acuerdo inicial. Solicitudes adicionales pueden incurrir en costos extra.|" +

                    "Propiedad Intelectual: Todos los materiales, diseños y documentación proporcionados siguen siendo propiedad intelectual de la empresa hasta que el pago total sea recibido. No se permite la reproducción ni modificación sin permiso escrito.|" +
                    "Confidencialidad: Toda información compartida por el cliente será tratada de manera confidencial. No compartiremos ni divulgaremos información personal o del proyecto a terceros sin su autorización.|" +
                    "Jurisdicción y Ley Aplicable: Cualquier disputa o controversia que surja en relación con estos términos estará sujeta a las leyes de nuestra jurisdicción local, y se resolverá en los tribunales correspondientes.|" +
                    "Limitación de Responsabilidad: La empresa no se responsabiliza por daños indirectos, incidentales o consecuentes derivados del uso de nuestros servicios, excepto en la medida en que lo exija la ley.|" +
                    "Modificación de Términos: Nos reservamos el derecho de actualizar o modificar estos términos en cualquier momento. Cualquier cambio se publicará en esta página y entrará en vigor de inmediato.|" +

                    "Entrega de Proyecto: El proyecto será entregado en el plazo y formato especificado en el acuerdo. Nos comprometemos a trabajar dentro de los plazos acordados, siempre que el cliente cumpla con sus responsabilidades.|" +
                    "Garantía de Servicio: Nos esforzamos por ofrecer un servicio de alta calidad. En caso de problemas o insatisfacción, el cliente debe contactar a nuestro equipo de soporte dentro de los primeros 30 días posteriores a la entrega.|" +
                    "Soporte y Asistencia: Ofrecemos soporte técnico y asistencia postventa. El cliente puede comunicarse con nuestro equipo de atención al cliente para resolver cualquier duda o problema relacionado con el servicio.|" +
                    "Contacto: Para cualquier pregunta o aclaración sobre estos términos, contáctenos en soporte@fsestudio.com o llame al +52 6622 29 00 254.|",
                    "v1.0", // Versión personalizada
                    new DateTime(2024, 11, 7) // Fecha de los términos
                )
            };
        }
    }
}
