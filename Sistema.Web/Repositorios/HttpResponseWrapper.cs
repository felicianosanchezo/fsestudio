using System.Net;

namespace Sistema.Web.Repositorios
{
    public class HttpResponseWrapper<T>
    {
        public bool Error { get; set; }
        public T? Response { get; set; }
        public HttpResponseMessage HttpResponseMessage { get; set; }

        public HttpResponseWrapper(T? response, bool error, HttpResponseMessage httpResponseMessage)
        {
            Error = error;
            Response = response;
            HttpResponseMessage = httpResponseMessage;
        }

        // Método para obtener mensajes de error personalizados basados en el código de estado HTTP
        public async Task<string?> GetErrorMessageAsync()
        {
            if (!Error)
            {
                return null;
            }

            var codigoEstatus = HttpResponseMessage.StatusCode;

            // Se utiliza un "switch" para devolver un mensaje específico según el código de estado
            return codigoEstatus switch
            {
                HttpStatusCode.NotFound => "Recurso no encontrado",  // Error 404
                HttpStatusCode.BadRequest => await HttpResponseMessage.Content.ReadAsStringAsync(),  // Error 400
                HttpStatusCode.Unauthorized => "Usuario no autorizado o sesión expirada",  // Error 401
                HttpStatusCode.Forbidden => "Acceso prohibido",  // Error 403
                HttpStatusCode.InternalServerError => "Error interno del servidor",  // Error 500
                HttpStatusCode.ServiceUnavailable => "Servicio no disponible",  // Error 503
                HttpStatusCode.RequestTimeout => "La solicitud ha tardado demasiado",  // Error 408
                HttpStatusCode.TooManyRequests => "Demasiadas solicitudes en poco tiempo. Inténtalo más tarde.",  // Error 429
                _ => "Ha ocurrido un error inesperado"  // Cualquier otro error no manejado
            };
        }
    }
}
