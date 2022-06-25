using Grpc.Core; 
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using grpcMessageServer;
using grpcMessageServerStreaming;
using grpcMessageServerStreamingClient;
using grpcMessageServerStreamingBiDirect;

namespace grpcServer
{ 
   // Bi-Directional Streaming türünde bir imzadır. Stream request gönderilir ve stream response alınır
    public class MessageServiceStreamingBiDirect : MessageStreamingBiDirect.MessageStreamingBiDirectBase
    {
        public override async Task SendMessage(IAsyncStreamReader<MessageStreamingBiDirectRequest> requestStream, IServerStreamWriter<MessageStreamingBiDirectResponse> responseStream, ServerCallContext context)
        {
            // 1. Thread
            var task1 = Task.Run(async () =>
            {
                while (await requestStream.MoveNext(context.CancellationToken))
                {
                    System.Console.WriteLine($"Message : {requestStream.Current.Message} | Name : {requestStream.Current.Name}");
                }    
            });

            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(1000);
                await responseStream.WriteAsync(new MessageStreamingBiDirectResponse { Message = "Mesaj " + i });
            }

            await task1;
        }

    }
}
