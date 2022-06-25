using Grpc.Core; 
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using grpcMessageServer;
using grpcMessageServerStreaming;
using grpcMessageServerStreamingClient;

namespace grpcServer
{ 
   // Client Streaming türünde bir imzadır. Birden fazla istek yapılıyor stream olarak ve tek bir response alınır
    public class MessageServiceStreamingCli : MessageStreamingCli.MessageStreamingCliBase
    {
        public override async Task<MessageStreamingCliResponse> SendMessage(IAsyncStreamReader<MessageStreamingCliRequest> requestStream, ServerCallContext context)
        {
            while (await requestStream.MoveNext(context.CancellationToken))
            {
                System.Console.WriteLine($"Message : {requestStream.Current.Message} | Name : {requestStream.Current.Name}");
            }

            return new MessageStreamingCliResponse
            {
                Message = "Veri alınmıştır.."
            };
        }

    }
}
