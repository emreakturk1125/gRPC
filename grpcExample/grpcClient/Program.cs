using Grpc.Net.Client;
using grpcClient;
using grpcMessageClient;
using grpcMessageClientStreaming;
using grpcMessageServerStreamingBiDirect;
using grpcMessageServerStreamingClient;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace grpcClient
{

    // Not : grpcClient.csproj  dosyasında da  düzenleme yapmalısın. Aşağıdaki itemler olmalıdır

    //   <ItemGroup>
    //	<Protobuf Include = "Protos\greet.proto" GrpcServices="Client" />
    //	<Protobuf Include = "Protos\messageStreaming.proto" GrpcServices="Client" />
    //	<Protobuf Include = "Protos\message.proto" GrpcServices="Client" />
    //	<Protobuf Include = "Protos\messageStreamingCli.proto" GrpcServices="Client" />
    //</ItemGroup>
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");


            #region Unary

            //var messageClient = new Message.MessageClient(channel);
            //MessageResponse response = await messageClient.SendMessageAsync(new MessageRequest { Name = "Emre", Message = "Client dan selamlar" });

            //var greetClient = new Greeter.GreeterClient(channel);
            //HelloReply response = await greetClient.SayHelloAsync(new HelloRequest { Name = "Emre Aktürk den Request" }); 

            #endregion

            #region Server Streaming

            //var messageClient = new MessageStreaming.MessageStreamingClient(channel);
            //var response = messageClient.SendMessage(new MessageStreamingRequest
            //{
            //    Name = "Mahmut",
            //    Message = "Client dan selamlar"
            //});

            //CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

            //while (await response.ResponseStream.MoveNext(cancellationTokenSource.Token))   // MoveNext => stream ile gelecek her datayı yakalayacak fonksiyondur.
            //{
            //    System.Console.WriteLine(response.ResponseStream.Current.Message);
            //}

            #endregion

            #region Client Streaming

            //var messageClient = new MessageStreamingCli.MessageStreamingCliClient(channel);
            //var request = messageClient.SendMessage();

            //for (int i = 0; i < 10; i++)
            //{
            //    await Task.Delay(1000);
            //    await request.RequestStream.WriteAsync(new MessageStreamingCliRequest
            //    {
            //        Message = "Mesaj " + i,
            //        Name = "Emre"
            //    });
            //}
            //await request.RequestStream.CompleteAsync();  // Anlamı : Gönderilecek data bitmiştir. Bu kısım olmalıdır. aksi durumda server tarafı sürekli data beklicek 

            //System.Console.WriteLine((await request.ResponseAsync).Message);    

            #endregion

            #region Bi-Directional Streaming

            var messageClient = new MessageStreamingBiDirect.MessageStreamingBiDirectClient(channel);
            var request = messageClient.SendMessage();

            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

           var task1 =  Task.Run(async () =>
            {
                for (int i = 0; i < 10; i++)
                {
                    await Task.Delay(1000);
                    await request.RequestStream.WriteAsync(new MessageStreamingBiDirectRequest
                    {
                        Message = "Mesaj " + i,
                        Name = "Emre"
                    });
                }
            });

            while (await request.ResponseStream.MoveNext(cancellationTokenSource.Token))
            {
                System.Console.WriteLine(request.ResponseStream.Current.Message);

            }

            await task1;
            await request.RequestStream.CompleteAsync();
              
            #endregion

        }
    }
}
