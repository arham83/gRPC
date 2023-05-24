using Grpc.Net.Client;
using GrpcService;
using System;
using System.IO;
using System.Threading.Tasks;
using gRPC.Client.SerializerDeserializer;
using Google.Protobuf;
using BenchmarkDotNet.Running;
using GrpcClient.BenchMarkIT;
using GrpcClient.DTOs;
using System.Linq;
using GrpcClient.Mapper;
using System.Net.Http;
using System.Collections.Generic;
using static GrpcService.Messaging;

namespace GrpcClient
{
    class Program
    {
        static void Main(string[] args)
        {
         
            //var summary2 = BenchmarkRunner.Run<BenchMarkUsingProtoBuf>();
            var SOM = D2PMapper.InitOMFromDTO(@"D:\LayerOne\Project - gRPC\Project-V2-Working\GrpcClient\GrpcClient\SampleMessages\smallOptimized.json");
            var BOM = D2PMapper.InitOMFromDTO(@"D:\LayerOne\Project - gRPC\Project-V2-Working\GrpcClient\GrpcClient\SampleMessages\bigOptimized.json");
            var SFM = D2PMapper.InitFMFromDTO(@"D:\LayerOne\Project - gRPC\Project-V2-Working\GrpcClient\GrpcClient\SampleMessages\smallFull.json");
            var BFM = D2PMapper.InitFMFromDTO(@"D:\LayerOne\Project - gRPC\Project-V2-Working\GrpcClient\GrpcClient\SampleMessages\bigFull.json");
            var pbBytes1 = SOM.ToByteArray();
            var pbBytes2 = BOM.ToByteArray();
            var pbBytes3 = SFM.ToByteArray();
            var pbBytes4 = BFM.ToByteArray();

            
            Console.WriteLine("Serialized Message Size Using gRPC - SFM " + pbBytes3.Length);
            Console.WriteLine("Serialized Message Size Using gRPC - SOM " + pbBytes1.Length);
            Console.WriteLine("Serialized Message Size Using gRPC - BFM " + pbBytes4.Length);
            Console.WriteLine("Serialized Message Size Using gRPC - BOM " + pbBytes2.Length);
            Console.WriteLine("Press any key to exit ");
            Console.ReadLine();

        }
    }
}