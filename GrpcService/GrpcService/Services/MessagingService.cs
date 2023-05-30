using Grpc.Core;
using GrpcClient.DTOs;
using GrpcService.Miscellaneous;
using GrpcService.Tests;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcService.Services
{
    public class MessagingService : Messaging.MessagingBase
    {
        private readonly ILogger<MessagingService> _logger;
        public MessagingService(ILogger<MessagingService> logger)
        {
            _logger = logger;
        }

        public override Task<ServerReply> GetFullMessage(FullMessage request, ServerCallContext context)
        {
            return Task.FromResult(new ServerReply
            {
                Reply = "Message Transferred Successfully"
            });
        }

        public override Task<ServerReply> TestSFM(FullMessage request, ServerCallContext context)
        {
            var RFM = Misc.JsonHandler.DeserializeJson<FullMessageDTO>(Misc.GetPath(@"SampleMessages\smallFull.json"));
            bool areEqual = new Comparer().CompareFM(RFM, request);
            var reply = "Test Passsed" + areEqual;
            return Task.FromResult(new ServerReply
            {
                Reply = reply
            });
        }

        public override Task<ServerReply> TestBFM(FullMessage request, ServerCallContext context)
        {
            var RFM = Misc.JsonHandler.DeserializeJson<FullMessageDTO>(Misc.GetPath(@"SampleMessages\smallFull.json"));
            bool areEqual = new Comparer().CompareFM(RFM, request);
            var reply = "Test Passsed" + areEqual;
            return Task.FromResult(new ServerReply
            {
                Reply = reply
            });
        }
        public override Task<ServerReply> GetOptimizedMessage(OptimizedMessage request, ServerCallContext context)
        {
            return Task.FromResult(new ServerReply
            {
                Reply = "Message Transferred Successfully"
            });
        }
        public override Task<ServerReply> TestSOM(OptimizedMessage request, ServerCallContext context)
        {
            var ROM = Misc.JsonHandler.DeserializeJson<OptimizedMessageDTO>(Misc.GetPath(@"SampleMessages\smallOptimized.json"));
            bool areEqual = new Comparer().CompareOM(ROM, request);
            var reply = "Test Passsed" + areEqual;
            return Task.FromResult(new ServerReply
            {
                Reply = reply
            });
        }
        public override Task<ServerReply> TestBOM(OptimizedMessage request, ServerCallContext context)
        {
            var ROM = Misc.JsonHandler.DeserializeJson<OptimizedMessageDTO>(Misc.GetPath(@"SampleMessages\bigOptimized.json"));
            bool areEqual = new Comparer().CompareOM(ROM, request);
            var reply = "Test Passsed" + areEqual;
            return Task.FromResult(new ServerReply
            {
                Reply = reply
            });
        }
    }
}
