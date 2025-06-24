using Sistema.Entidades.Dto.FsEstudio;
using Sistema.Web.Repositorios;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sistema.Web.Repositorios
{


    public class Repositorio : IRepositorio
    {
        private readonly HttpClient _httpClient;
        private JsonSerializerOptions _jsonDefaultOptions => new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            ReferenceHandler = ReferenceHandler.Preserve,
            MaxDepth = 100
        };

        public Repositorio(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseWrapper<T>> Get<T>(string url)
        {
            var responseHttp = await _httpClient.GetAsync(url);
            if (responseHttp.IsSuccessStatusCode)
            {
                var response = await UnserializeAnswer<T>(responseHttp, _jsonDefaultOptions);
                return new HttpResponseWrapper<T>(response, false, responseHttp);
            }
            return new HttpResponseWrapper<T>(default, true, responseHttp);
        }

        public async Task<HttpResponseWrapper<object>> Post<T>(string url, T model)
        {
            var mesageJSON = JsonSerializer.Serialize(model);
            var messageContet = new StringContent(mesageJSON, Encoding.UTF8,
                "application/json");
            var responseHttp = await _httpClient.PostAsync(url, messageContet);
            return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);

        }

        public async Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T model)
        {
            var messageJSON = JsonSerializer.Serialize(model);
            var messageContet = new StringContent(messageJSON, Encoding.UTF8, "application/json");
            var responseHttp = await _httpClient.PostAsync(url, messageContet);
            if (responseHttp.IsSuccessStatusCode)
            {
                var response = await UnserializeAnswer<TResponse>(responseHttp, _jsonDefaultOptions);
                return new HttpResponseWrapper<TResponse>(response, false, responseHttp);
            }
            return new HttpResponseWrapper<TResponse>(default, !responseHttp.IsSuccessStatusCode, responseHttp);
        }



        public async Task<HttpResponseWrapper<PaymentIntentResponse>> PostStrip<T>(string url, T model)
        {
            var messageJSON = JsonSerializer.Serialize(model);
            var messageContent = new StringContent(messageJSON, Encoding.UTF8, "application/json");
            var responseHttp = await _httpClient.PostAsync(url, messageContent);

            if (responseHttp.IsSuccessStatusCode)
            {
                var response = await UnserializeAnswer<PaymentIntentResponse>(responseHttp, _jsonDefaultOptions);
                return new HttpResponseWrapper<PaymentIntentResponse>(response, false, responseHttp);
            }
            return new HttpResponseWrapper<PaymentIntentResponse>(default, !responseHttp.IsSuccessStatusCode, responseHttp);
        }


        public async Task<HttpResponseWrapper<TResponse>> Put<T, TResponse>(string url, T model)
        {
            var messageJSON = JsonSerializer.Serialize(model);
            var messageContent = new StringContent(messageJSON, Encoding.UTF8, "application/json");
            var responseHttp = await _httpClient.PutAsync(url, messageContent);
            if (responseHttp.IsSuccessStatusCode)
            {
                var response = await UnserializeAnswer<TResponse>(responseHttp, _jsonDefaultOptions);
                return new HttpResponseWrapper<TResponse>(response, false, responseHttp);

            }
            return new HttpResponseWrapper<TResponse>(default, !responseHttp.IsSuccessStatusCode, responseHttp);

        }



        public async Task<HttpResponseWrapper<object>> Put<T>(string url, T model)
        {
            var messageJSON = JsonSerializer.Serialize(model);
            var messageContent = new StringContent(messageJSON, Encoding.UTF8, "application/json");
            var responseHttp = await _httpClient.PutAsync(url, messageContent);
            return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);
        }

        public async Task<HttpResponseWrapper<object>> Delete(string url)
        {
            var responseHTTP = await _httpClient.DeleteAsync(url);
            return new HttpResponseWrapper<object>(null, !responseHTTP.IsSuccessStatusCode, responseHTTP);
        }

        private async Task<T> UnserializeAnswer<T>(HttpResponseMessage httpResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            var respuestaString = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(respuestaString,
                jsonSerializerOptions)!;
        }

        public async Task<HttpResponseWrapper<object>> PostMultipartContent(string url, MultipartFormDataContent formDataContent)
        {
            var responseHttp = await _httpClient.PostAsync(url, formDataContent);

            if (responseHttp.IsSuccessStatusCode)
            {
                return new HttpResponseWrapper<object>(null, false, responseHttp);
            }
            return new HttpResponseWrapper<object>(null, true, responseHttp);
        }


        public async Task<HttpResponseWrapper<object>> PutMultipartContent(string url, MultipartFormDataContent content)
        {
            var response = await _httpClient.PutAsync(url, content);

            // No se necesita deserializar contenido, solo devolver si fue exitoso o no
            return new HttpResponseWrapper<object>(null, !response.IsSuccessStatusCode, response);
        }


    }
}
