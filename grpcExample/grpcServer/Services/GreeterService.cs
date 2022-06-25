using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace grpcServer
{ 
    // "Unary" türünde bir imzadır. tek bir istek gönderilir ve tek bir response   alınır
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            System.Console.WriteLine(request.Name);
            return Task.FromResult(new HelloReply
            {
                Message = "Merhaba " + request.Name
            });
        }
    }
}
