// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/Messages.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcService {
  public static partial class Messaging
  {
    static readonly string __ServiceName = "Message.Messaging";

    static readonly grpc::Marshaller<global::GrpcService.FullMessage> __Marshaller_Message_FullMessage = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.FullMessage.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.ServerReply> __Marshaller_Message_ServerReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.ServerReply.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.OptimizedMessage> __Marshaller_Message_OptimizedMessage = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.OptimizedMessage.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcService.FullMessage, global::GrpcService.ServerReply> __Method_GetFullMessage = new grpc::Method<global::GrpcService.FullMessage, global::GrpcService.ServerReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetFullMessage",
        __Marshaller_Message_FullMessage,
        __Marshaller_Message_ServerReply);

    static readonly grpc::Method<global::GrpcService.OptimizedMessage, global::GrpcService.ServerReply> __Method_GetOptimizedMessage = new grpc::Method<global::GrpcService.OptimizedMessage, global::GrpcService.ServerReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetOptimizedMessage",
        __Marshaller_Message_OptimizedMessage,
        __Marshaller_Message_ServerReply);

    static readonly grpc::Method<global::GrpcService.OptimizedMessage, global::GrpcService.ServerReply> __Method_TestSOM = new grpc::Method<global::GrpcService.OptimizedMessage, global::GrpcService.ServerReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "TestSOM",
        __Marshaller_Message_OptimizedMessage,
        __Marshaller_Message_ServerReply);

    static readonly grpc::Method<global::GrpcService.OptimizedMessage, global::GrpcService.ServerReply> __Method_TestBOM = new grpc::Method<global::GrpcService.OptimizedMessage, global::GrpcService.ServerReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "TestBOM",
        __Marshaller_Message_OptimizedMessage,
        __Marshaller_Message_ServerReply);

    static readonly grpc::Method<global::GrpcService.FullMessage, global::GrpcService.ServerReply> __Method_TestSFM = new grpc::Method<global::GrpcService.FullMessage, global::GrpcService.ServerReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "TestSFM",
        __Marshaller_Message_FullMessage,
        __Marshaller_Message_ServerReply);

    static readonly grpc::Method<global::GrpcService.FullMessage, global::GrpcService.ServerReply> __Method_TestBFM = new grpc::Method<global::GrpcService.FullMessage, global::GrpcService.ServerReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "TestBFM",
        __Marshaller_Message_FullMessage,
        __Marshaller_Message_ServerReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcService.MessagesReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Messaging</summary>
    [grpc::BindServiceMethod(typeof(Messaging), "BindService")]
    public abstract partial class MessagingBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GrpcService.ServerReply> GetFullMessage(global::GrpcService.FullMessage request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.ServerReply> GetOptimizedMessage(global::GrpcService.OptimizedMessage request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.ServerReply> TestSOM(global::GrpcService.OptimizedMessage request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.ServerReply> TestBOM(global::GrpcService.OptimizedMessage request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.ServerReply> TestSFM(global::GrpcService.FullMessage request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.ServerReply> TestBFM(global::GrpcService.FullMessage request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(MessagingBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetFullMessage, serviceImpl.GetFullMessage)
          .AddMethod(__Method_GetOptimizedMessage, serviceImpl.GetOptimizedMessage)
          .AddMethod(__Method_TestSOM, serviceImpl.TestSOM)
          .AddMethod(__Method_TestBOM, serviceImpl.TestBOM)
          .AddMethod(__Method_TestSFM, serviceImpl.TestSFM)
          .AddMethod(__Method_TestBFM, serviceImpl.TestBFM).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, MessagingBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetFullMessage, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.FullMessage, global::GrpcService.ServerReply>(serviceImpl.GetFullMessage));
      serviceBinder.AddMethod(__Method_GetOptimizedMessage, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.OptimizedMessage, global::GrpcService.ServerReply>(serviceImpl.GetOptimizedMessage));
      serviceBinder.AddMethod(__Method_TestSOM, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.OptimizedMessage, global::GrpcService.ServerReply>(serviceImpl.TestSOM));
      serviceBinder.AddMethod(__Method_TestBOM, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.OptimizedMessage, global::GrpcService.ServerReply>(serviceImpl.TestBOM));
      serviceBinder.AddMethod(__Method_TestSFM, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.FullMessage, global::GrpcService.ServerReply>(serviceImpl.TestSFM));
      serviceBinder.AddMethod(__Method_TestBFM, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.FullMessage, global::GrpcService.ServerReply>(serviceImpl.TestBFM));
    }

  }
}
#endregion
