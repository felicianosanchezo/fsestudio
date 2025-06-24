namespace Sistema.Web.Repositorios
{
    public interface IRepositorio
    {
        Task<HttpResponseWrapper<T>> Get<T>(string url);
        Task<HttpResponseWrapper<object>> Post<T>(string url, T model);
        Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T model);
        Task<HttpResponseWrapper<TResponse>> Put<T, TResponse>(string url, T model);
        Task<HttpResponseWrapper<object>> Put<T>(string url, T model);
        Task<HttpResponseWrapper<object>> Delete(string url);


        // Nuevo método para enviar MultipartFormDataContent (archivos y otros datos)
        Task<HttpResponseWrapper<object>> PostMultipartContent(string url, MultipartFormDataContent formDataContent);

        Task<HttpResponseWrapper<object>> PutMultipartContent(string url, MultipartFormDataContent content);

    }
}
