// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/FullMessage.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcService {
  public static partial class FullMessaging
  {
    static readonly string __ServiceName = "Message.FullMessaging";

    static readonly grpc::Marshaller<global::GrpcService.ClientRequest> __Marshaller_Message_ClientRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.ClientRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.ServerReply> __Marshaller_Message_ServerReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.ServerReply.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcService.ClientRequest, global::GrpcService.ServerReply> __Method_GetMessage = new grpc::Method<global::GrpcService.ClientRequest, global::GrpcService.ServerReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetMessage",
        __Marshaller_Message_ClientRequest,
        __Marshaller_Message_ServerReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcService.FullMessageReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of FullMessaging</summary>
    [grpc::BindServiceMethod(typeof(FullMessaging), "BindService")]
    public abstract partial class FullMessagingBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GrpcService.ServerReply> GetMessage(global::GrpcService.ClientRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(FullMessagingBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetMessage, serviceImpl.GetMessage).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, FullMessagingBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetMessage, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.ClientRequest, global::GrpcService.ServerReply>(serviceImpl.GetMessage));
    }

  }
}
#endregion
