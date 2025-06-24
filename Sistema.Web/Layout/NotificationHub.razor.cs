using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sistema.Web.Layout
{
    public partial class NotificationHub : IAsyncDisposable
    {
        private HubConnection connection;
        private bool isConnected = false;
        private readonly NavigationManager _navigationManager;
        [Inject] private AuthenticationStateProvider AuthenticationStateProvider { get; set; } // Inyección correcta de AuthenticationStateProvider

        // Evento que se dispara cuando se recibe una notificación
        public event Action<string> OnNotificationReceived;

        public async Task IniciarConexionAsync(string role, string userId)
        {
            if (string.IsNullOrEmpty(role))
            {
                Console.WriteLine("El rol no puede ser nulo o vacío.");
                return;
            }

            if (connection == null || connection.State == HubConnectionState.Disconnected)
            {



                try
                {
                    //connection = new HubConnectionBuilder()
                    //    .WithUrl("https://localhost:7243/notificacionesHub")
                    //                    .WithAutomaticReconnect()
                    //                    .Build();

                    connection = new HubConnectionBuilder()
                        .WithUrl("https://sistemaapi-fsestudio.azurewebsites.net/")
                                        .WithAutomaticReconnect()
                                        .Build();






                    // Configurar el evento cuando se recibe una notificación en tiempo real
                    connection.On<string>("RecibirNotificacion", (mensaje) =>
                    {
                        OnNotificationReceived?.Invoke(mensaje); // Invocar el evento para manejar la notificación recibida
                    });





                    // Iniciar la conexión
                    await connection.StartAsync();


                    if (!string.IsNullOrEmpty(userId)) { await connection.SendAsync("UnirseAGrupo", userId); }
                    if (!string.IsNullOrEmpty(role)) { await connection.SendAsync("UnirseAGrupo", role); }


                    Console.WriteLine("Conexión a SignalR establecida y unido al grupo.");
                    isConnected = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error conectando con SignalR: {ex.Message}");
                }
            }
            else if (connection.State == HubConnectionState.Connected)
            {
                Console.WriteLine("Ya estás conectado a SignalR.");
            }
        }

        public async Task DesconectarAsync()
        {
            if (connection != null && connection.State == HubConnectionState.Connected)
            {
                try
                {
                    await connection.StopAsync();
                    Console.WriteLine("Conexión a SignalR cerrada.");
                    isConnected = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al desconectar de SignalR: {ex.Message}");
                }
            }
        }

        public async ValueTask DisposeAsync()
        {
            if (connection != null)
            {
                await DesconectarAsync();
                await connection.DisposeAsync();
                Console.WriteLine("Conexión a SignalR terminada.");
            }
        }
    }
}
