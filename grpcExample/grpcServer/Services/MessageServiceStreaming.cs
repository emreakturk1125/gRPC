using Grpc.Core; 
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using grpcMessageServer;
using grpcMessageServerStreaming;

namespace grpcServer
{ 
    // "Server Streaming" türünde bir imzadır. tek bir istek gönderilir ve birden fazla response alınır
    public class MessageServiceStreaming  : MessageStreaming.MessageStreamingBase
    {
        public override async Task SendMessage(MessageStreamingRequest request, IServerStreamWriter<MessageStreamingResponse> responseStream, ServerCallContext context)
        {
            System.Console.WriteLine($"(Stream) Message : {request.Message} | Name : {request.Name}");

            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(1000);
                await responseStream.WriteAsync(new MessageStreamingResponse
                {
                    Message = "Merhaba " + i
                });
            }
        }

    }
}
