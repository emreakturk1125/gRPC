using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using grpcFileTransportServer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FileTransaction.GrpcServer
{
    public class FileTransportService : FileService.FileServiceBase
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public FileTransportService(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
         
        public override async Task<Empty> FileUpload(IAsyncStreamReader<BytesContent> requestStream, ServerCallContext context)
        {
            // Server da  stream'in yapılacağı dizini belirleyelim
            string path = @"D:\gRPC Example\grpcExample\grpcExample\FileTransaction.GrpcServer\StreamFiles";

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            FileStream fileStream = null;

            try
            {
                int count = 0;

                decimal chunkSize = 0;

                while(await requestStream.MoveNext())
                {
                    if (count++ == 0)
                    {
                        fileStream = new FileStream($"{path}/{requestStream.Current.Info.FileName}{requestStream.Current.Info.FileExtension}", FileMode.CreateNew);
                        fileStream.SetLength(requestStream.Current.FileSize);   
                    }
                    var buffer = requestStream.Current.Buffer.ToByteArray();    
                    await fileStream.WriteAsync(buffer,0, buffer.Length);
                    System.Console.WriteLine($"{Math.Round((chunkSize += requestStream.Current.ReadedByte) * 100) / requestStream.Current.FileSize}%");
                }
            }
            catch (Exception)
            {

                throw;
            }
             
            await fileStream.DisposeAsync();    
            fileStream.Close();
            return new Empty();
        }

        public override async Task FileDownload(grpcFileTransportServer.FileInfo request, IServerStreamWriter<BytesContent> responseStream, ServerCallContext context)
        {
            string path = Path.Combine(_webHostEnvironment.WebRootPath, "files");
            FileStream fileStream = new FileStream($"{path}/{request.FileName}{request.FileExtension}",FileMode.Open,FileAccess.Read);
            byte[] buffer = new byte[2048];
            BytesContent bytesContent = new BytesContent
            {
                FileSize = fileStream.Length,
                Info = new grpcFileTransportServer.FileInfo { FileName = Path.GetFileNameWithoutExtension(fileStream.Name), FileExtension = Path.GetExtension(fileStream.Name) },
                ReadedByte = 0,
            };

            while ( (bytesContent.ReadedByte = await fileStream.ReadAsync(buffer,0,buffer.Length)) > 0)
            {
                bytesContent.Buffer = Google.Protobuf.ByteString.CopyFrom(buffer);
                await responseStream.WriteAsync(bytesContent);
            }

            fileStream.Close(); 
        }
    }
}
