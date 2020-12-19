using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcServerSideStreaming
{
    public class PrimeNumberService :PrimeNumber.PrimeNumberBase
    {
        private readonly ILogger<PrimeNumberService> _logger;
        public PrimeNumberService(ILogger<PrimeNumberService> logger)
        {
            _logger = logger;
        }
        public override async Task PrimeNumberMethod(PrimeManyTimeRequest request, IServerStreamWriter<PrimeManyTimeResposnce> responseStream, ServerCallContext context)
        {
            Console.WriteLine("Server recived info");
            //Console.WriteLine(request.PrimeReq.ToString());
            var f = 0;
            for (int i=2; i<=request.PrimeReq/2;i++)
            {
               
                if (request.PrimeReq % i == 0) { f = 1;break; }
                await Task.Delay(200);
                

            }
            if (f == 0)
            {
                await responseStream.WriteAsync(new PrimeManyTimeResposnce() { PrimeRes = request.PrimeReq + " is a Prime Number" });
                Console.WriteLine(request.PrimeReq + " is a Prime Number");
            }
            else
                await responseStream.WriteAsync(new PrimeManyTimeResposnce() { PrimeRes = request.PrimeReq + " is a Not Prime Number" });
            Console.WriteLine(request.PrimeReq + " is a Not Prime Number");
        }

    }
}
