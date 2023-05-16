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

namespace GrpcClient.BenchMarkIT
{
    public class BenchMarkUsingProtoBuf
    {

        private readonly OptimizedMessage SOM;
        private readonly Byte[] pbBytes1;

        private readonly OptimizedMessage BOM;
        private readonly Byte[] pbBytes2;

        private readonly FullMessage SFM;
        private readonly Byte[] pbBytes3;

        private readonly FullMessage BFM;
        private readonly Byte[] pbBytes4;

        private readonly GrpcChannel channel;
        private readonly Messaging.MessagingClient client;

        public BenchMarkUsingProtoBuf()
        {

            SOM = D2PMapper.InitOMFromDTO(@"D:\LayerOne\Project - gRPC\Project -V2\GrpcClient\GrpcClient\SampleMessages\smallOptimized.json");
            BOM = D2PMapper.InitOMFromDTO(@"D:\LayerOne\Project - gRPC\Project -V2\GrpcClient\GrpcClient\SampleMessages\bigOptimized.json");
            SFM = D2PMapper.InitFMFromDTO(@"D:\LayerOne\Project - gRPC\Project -V2\GrpcClient\GrpcClient\SampleMessages\smallFull.json");
            BFM = D2PMapper.InitFMFromDTO(@"D:\LayerOne\Project - gRPC\Project -V2\GrpcClient\GrpcClient\SampleMessages\bigFull.json");

            pbBytes1 = SOM.ToByteArray();
            pbBytes2 = BOM.ToByteArray();
            pbBytes3 = SFM.ToByteArray();
            pbBytes4 = BFM.ToByteArray();
            channel = GrpcChannel.ForAddress("https://localhost:5001",
                new GrpcChannelOptions
                {
                    MaxReceiveMessageSize = 100 * 1024 * 1024, // Set the maximum message size in bytes
                    MaxSendMessageSize = 100 * 1024 * 1024,
                });
            client = new Messaging.MessagingClient(channel);
        }


        [Benchmark]
        public void ProtoBufSerialization_SOM()
        {
            SOM.ToByteArray();
        }

        [Benchmark]
        public void InitOMFromDTO_SOM()
        {
            D2PMapper.InitOMFromDTO(@"D:\LayerOne\Project - gRPC\Project -V2\GrpcClient\GrpcClient\SampleMessages\smallOptimized.json");
        }

        [Benchmark]
        public void TransmissionTime_ProtoBuf_SOM()
        {
            ByteString myByteString = ByteString.CopyFrom(pbBytes1);
            var reply = client.GetOptimizedMessage(new ClientRequest { Message = myByteString });
        }

        [Benchmark]

        public void ProtoBufDeserialization_SOM()
        {
            OptimizedMessage.Parser.ParseFrom(pbBytes1);
        }

        [Benchmark]
        public void ProtoBufSerialization_BOM()
        {
            BOM.ToByteArray();
        }

        [Benchmark]
        public void InitOMFromDTO_BOM()
        {
            D2PMapper.InitOMFromDTO(@"D:\LayerOne\Project - gRPC\Project -V2\GrpcClient\GrpcClient\SampleMessages\bigOptimized.json");
        }

        [Benchmark]
        public void TransmissionTime_ProtoBuf_BOM()
        {
            ByteString myByteString = ByteString.CopyFrom(pbBytes2);
            var reply = client.GetOptimizedMessage(new ClientRequest { Message = myByteString });
        }

        [Benchmark]
        public void ProtoBufDeserialization_BOM()
        {
            OptimizedMessage.Parser.ParseFrom(pbBytes2);
        }

        [Benchmark]
        public void ProtoBufSerialization_SFM()
        {
            SFM.ToByteArray();
        }
        [Benchmark]
        public void InitOMFromDTO_SFM()
        {
            D2PMapper.InitFMFromDTO(@"D:\LayerOne\Project - gRPC\Project -V2\GrpcClient\GrpcClient\SampleMessages\smallFull.json");
        }
        [Benchmark]
        public void TransmissionTime_ProtoBuf_SFM()
        {
            ByteString myByteString = ByteString.CopyFrom(pbBytes3);
            var reply = client.GetFullMessage(new ClientRequest { Message = myByteString });
        }

        [Benchmark]

        public void ProtoBufDeserialization_SFM()
        {
            FullMessage.Parser.ParseFrom(pbBytes3);
        }

        [Benchmark]
        public void ProtoBufSerialization_BFM()
        {
            BFM.ToByteArray();
        }

        [Benchmark]
        public void InitOMFromDTO_BFM()
        {
            D2PMapper.InitFMFromDTO(@"D:\LayerOne\Project - gRPC\Project -V2\GrpcClient\GrpcClient\SampleMessages\bigFull.json");
        }

        [Benchmark]
        public void TransmissionTime_ProtoBuf_BFM()
        {
            ByteString myByteString = ByteString.CopyFrom(pbBytes4);
            var reply = client.GetFullMessage(new ClientRequest { Message = myByteString });
        }

        [Benchmark]
        public void ProtoBufDeserialization_BFM()
        {
            FullMessage.Parser.ParseFrom(pbBytes4);
        }
    }
}
