using Grpc.Core;
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
            ServerReply response = new ServerReply();

            return Task.FromResult(new ServerReply
            {
                Reply = "Received Full Message"
            });
        }

        public override Task<ServerReply> GetOptimizedMessage(OptimizedMessage request, ServerCallContext context)
        {
            ServerReply response = new ServerReply();

            return Task.FromResult(new ServerReply
            {
                Reply = "Received Optimized Message"
            });
        }
    }
}
