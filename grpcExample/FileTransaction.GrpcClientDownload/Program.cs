using Google.Protobuf;
using Grpc.Net.Client;
using grpcFileTransportClientDownload;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace FileTransaction.GrpcClientDownload
{
    // File Download işlemi
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:10001");
            var client = new FileService.FileServiceClient(channel);

            string downloadPath = @"D:\gRPC Example\grpcExample\grpcExample\FileTransaction.GrpcClientDownload\DownloadFiles";

            var fileInfo = new grpcFileTransportClientDownload.FileInfo
            {
                FileExtension = ".mp4",
                FileName = "test1"
            };

            FileStream fileStream = null;
            var download = client.FileDownload(fileInfo);

            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();


            int count = 0;
            decimal chunkSize = 0;
            while (await download.ResponseStream.MoveNext(cancellationTokenSource.Token))
            {
                if (count++ == 0)
                {
                    fileStream = new FileStream($"{downloadPath}/{download.ResponseStream.Current.Info.FileName}{download.ResponseStream.Current.Info.FileExtension}", FileMode.CreateNew);
                    fileStream.SetLength(download.ResponseStream.Current.FileSize);
                }

                var buffer = download.ResponseStream.Current.Buffer.ToByteArray();
                await fileStream.WriteAsync(buffer, 0, download.ResponseStream.Current.ReadedByte);

                System.Console.WriteLine($"{Math.Round((chunkSize += download.ResponseStream.Current.ReadedByte) * 100) / download.ResponseStream.Current.FileSize}%");
                await fileStream.DisposeAsync();
                fileStream.Close();
            }
        }
    }
}
