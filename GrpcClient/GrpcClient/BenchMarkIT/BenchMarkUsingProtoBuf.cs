using GrpcService;
using System;
using System.Collections.Generic;
using System.Text;
using Grpc.Net.Client;
using gRPC.Client.SerializerDeserializer;
using BenchmarkDotNet.Attributes;
using Google.Protobuf;
using GrpcClient.DTOs;
using GrpcClient.Mapper;
using GrpcClient.Miscellaneous;

namespace GrpcClient.BenchMarkIT
{
    public class BenchMarkUsingProtoBuf
    {

        private readonly OptimizedMessage SOM;
        private readonly OptimizedMessage BOM;
        private readonly FullMessage SFM;
        private readonly FullMessage BFM;

        private readonly GrpcChannel channel;
        private readonly Messaging.MessagingClient client;

        public BenchMarkUsingProtoBuf()
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


        [Benchmark]
        public void TransmissionTime_ProtoBuf_SOM()
        {
            var reply = client.GetOptimizedMessage(SOM);
        }

        [Benchmark]
        public void TransmissionTime_ProtoBuf_BOM()
        {
            var reply = client.GetOptimizedMessage(BOM);
        }

        [Benchmark]
        public void TransmissionTime_ProtoBuf_SFM()
        {
            var reply = client.GetFullMessage(SFM);
        }

        [Benchmark]
        public void TransmissionTime_ProtoBuf_BFM()
        {
            var reply = client.GetFullMessage(BFM);
        }
    }
}
