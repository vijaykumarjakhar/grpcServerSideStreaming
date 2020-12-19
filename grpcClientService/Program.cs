using Grpc.Core;
using Grpc.Net.Client;
using GrpcServerSideStreaming;
using System;
using System.Threading.Tasks;

namespace grpcClientService
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new PrimeNumber.PrimeNumberClient(channel);
            var reply =  client.PrimeNumberMethod(new PrimeManyTimeRequest { PrimeReq=200});
            while (await reply.ResponseStream.MoveNext())
            {
                Console.WriteLine("PrimeNumber: " + reply.ResponseStream.Current.PrimeRes);
            }
           
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
