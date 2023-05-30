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
using GrpcClient.Miscellaneous;
using GrpcClient.Tests;

namespace GrpcClient
{
    class Program
    {
        static void Main(string[] args)
        {

            //var summary2 = BenchmarkRunner.Run<BenchMarkUsingProtoBuf>();

            var test = new Test();
            test.Test_BFM();
            test.Test_SFM();
            test.Test_BOM();
            test.Test_SOM();
            Console.WriteLine("Press any key to exit ");
            Console.ReadLine();

        }
    }
}