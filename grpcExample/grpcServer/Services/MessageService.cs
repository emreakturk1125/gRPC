using Grpc.Core; 
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using grpcMessageServer;

namespace grpcServer
{

    // "Unary" türünde bir imzadır. tek bir istek gönderilir ve tek bir response   alınır
    public class MessageService  : Message.MessageBase
    {
        public override  Task<MessageResponse> SendMessage(MessageRequest request, ServerCallContext context)
        {
           
            System.Console.WriteLine($"Message : {request.Message} | Name : {request.Name}");
            return Task.FromResult(new MessageResponse
            {
                Message = "Mesaj başarı ile alınmıştır."
            });

             
        }
    }
}
