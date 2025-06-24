using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Sistema.Web;
using Sistema.Web.Repositorios;
using Sistema.Web.Auth;

using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.SignalR.Client;
using CurrieTechnologies.Razor.SweetAlert2;
using Sistema.Web.Layout;
using System;
using System.Net.Http;
using System.Globalization;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Agregar el componente principal de la aplicación en el HTML
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");



//var baseAddress = new Uri("https://localhost:7243/");
//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = baseAddress });


var baseAddress = new Uri("https://sistemaapi-fsestudio.azurewebsites.net/");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = baseAddress });

// Configurar la cultura predeterminada
var defaultCulture = new CultureInfo("es-MX"); // Cambia "es-MX" según sea necesario
CultureInfo.DefaultThreadCurrentCulture = defaultCulture;
CultureInfo.DefaultThreadCurrentUICulture = defaultCulture;

// Registro del servicio de almacenamiento local (LocalStorage)
builder.Services.AddBlazoredLocalStorage();

// Configuración de autenticación y autorización
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationProviderJWT>();
builder.Services.AddScoped<AuthenticationStateProvider, AuthenticationProviderJWT>();
builder.Services.AddScoped<ILoginServicio, AuthenticationProviderJWT>();

// Registro del servicio de repositorio
builder.Services.AddScoped<IRepositorio, Repositorio>();


// Registro de SweetAlert2 para notificaciones visuales
builder.Services.AddSweetAlert2();





builder.Services.AddScoped(sp =>
{
    var authStateProvider = sp.GetRequiredService<AuthenticationStateProvider>();

    var connection = new HubConnectionBuilder()
        .WithUrl("https://sistemaapi-fsestudio.azurewebsites.net/notificacionesHub", options =>
        {
            options.AccessTokenProvider = async () =>
            {
                var authState = await authStateProvider.GetAuthenticationStateAsync();
                var user = authState.User;
                var token = user.FindFirst("access_token")?.Value; // Ajusta el nombre del claim si es necesario
                return token;
            };
        })
        .WithAutomaticReconnect()
        .Build();

    return connection;
});

//builder.Services.AddScoped(sp =>
//{
//    var authStateProvider = sp.GetRequiredService<AuthenticationStateProvider>();

//    var connection = new HubConnectionBuilder()
//        .WithUrl("https://localhost:7243/notificacionesHub", options =>
//        {
//            options.AccessTokenProvider = async () =>
//            {
//                var authState = await authStateProvider.GetAuthenticationStateAsync();
//                var user = authState.User;
//                var token = user.FindFirst("access_token")?.Value; // Ajusta el nombre del claim si es necesario
//                return token;
//            };
//        })
//        .WithAutomaticReconnect()
//        .Build();

//    return connection;
//});




// Registro de NotificationHub
builder.Services.AddScoped<NotificationHub>();

// Correr la aplicación Blazor WebAssembly

await builder.Build().RunAsync();