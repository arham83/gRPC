using Grpc.Net.Client;
using GrpcClient.Mapper;
using GrpcClient.Miscellaneous;
using GrpcService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GrpcClient.Tests
{
    public class Test
    {
        private readonly OptimizedMessage SOM;
        private readonly OptimizedMessage BOM;
        private readonly FullMessage SFM;
        private readonly FullMessage BFM;

        private readonly GrpcChannel channel;
        private readonly Messaging.MessagingClient client;

        public Test()
        {
            SOM = D2PMapper.InitOMFromDTO(Misc.GetPath(@"SampleMessages\smallOptimized.json"));
            BOM = D2PMapper.InitOMFromDTO(Misc.GetPath(@"SampleMessages\bigOptimized.json"));
            SFM = D2PMapper.InitFMFromDTO(Misc.GetPath(@"SampleMessages\smallFull.json"));
            BFM = D2PMapper.InitFMFromDTO(Misc.GetPath(@"SampleMessages\bigFull.json"));
            channel = GrpcChannel.ForAddress("https://localhost:5001",
                new GrpcChannelOptions
                {
                    MaxReceiveMessageSize = 100 * 1024 * 1024, // Set the maximum message size in bytes
                    MaxSendMessageSize = 100 * 1024 * 1024,
                });
            client = new Messaging.MessagingClient(channel);
        }
        public void Test_SFM()
        {
            var response = client.TestSFM(SFM);
            Console.WriteLine(response);
        }
        public void Test_BFM()
        {
            var response = client.TestBFM(BFM);
            Console.WriteLine(response);
        }
        public void Test_SOM()
        {
            var response = client.TestSOM(SOM);
            Console.WriteLine(response);
        }
        public void Test_BOM()
        {
            var response = client.TestBOM(BOM);
            Console.WriteLine(response);
        }
    }
}
