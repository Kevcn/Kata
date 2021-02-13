using System;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace GrpcService.Server.Services
{
    public class ChatService : Chat.ChatBase
    {
        private readonly ILogger<ChatService> _logger;
        public ChatService(ILogger<ChatService> logger)
        {
            _logger = logger;
        }
        
        public override async Task SendMessage(IAsyncStreamReader<ClientToServerMessage> requestStream, 
            IServerStreamWriter<ServerToClientMessage> responseStream, 
            ServerCallContext context)
        {
            var clientToServer = HandleClientToServerPing(requestStream, context);

            var serverToClient = HandleServerToClient(responseStream, context);

            await Task.WhenAll(clientToServer, serverToClient);
        }

        private static async Task HandleServerToClient(IServerStreamWriter<ServerToClientMessage> responseStream, ServerCallContext context)
        {
            var pingCount = 0;
            while (!context.CancellationToken.IsCancellationRequested)
            {
                await responseStream.WriteAsync(new ServerToClientMessage
                {
                    Text = $"Service Said hi {pingCount} times",
                    Timestamp = Timestamp.FromDateTime(DateTime.UtcNow)
                });
                pingCount++;
                await Task.Delay(1000);
            }
        }

        private async Task HandleClientToServerPing(IAsyncStreamReader<ClientToServerMessage> requestStream, ServerCallContext context)
        {
            while (await requestStream.MoveNext() && !context.CancellationToken.IsCancellationRequested)
            {
                var message = requestStream.Current;
                _logger.LogInformation($"The client said {message.Text}");
            }
        }
    }
}