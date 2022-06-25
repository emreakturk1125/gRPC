using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace grpcServer
{
    // Not : grpcServer.csproj  dosyasında da  düzenleme yapmalısın. Aşağıdaki itemler olmalıdır

    //<ItemGroup>
    //   <Protobuf Include = "Protos\greet.proto" GrpcServices="Server" />
    //   <Protobuf Include = "Protos\messageStreamingBiDirect.proto" GrpcServices="Server" />
    //   <Protobuf Include = "Protos\messageStreamingCli.proto" GrpcServices="Server" />
    //   <Protobuf Include = "Protos\messageStreaming.proto" GrpcServices="Server" />
    //   <Protobuf Include = "Protos\message.proto" GrpcServices="Server" />
    //</ItemGroup>
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        // Additional configuration is required to successfully run gRPC on macOS.
        // For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
