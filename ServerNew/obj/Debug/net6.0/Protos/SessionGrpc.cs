// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/Session.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ServerNew {
  public static partial class SendSession
  {
    static readonly string __ServiceName = "duplex.SendSession";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ServerNew.LoadByShowRequest> __Marshaller_duplex_LoadByShowRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ServerNew.LoadByShowRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ServerNew.SessionReply> __Marshaller_duplex_SessionReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ServerNew.SessionReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ServerNew.SessionLoadRequest> __Marshaller_duplex_SessionLoadRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ServerNew.SessionLoadRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ServerNew.SessionRequest> __Marshaller_duplex_SessionRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ServerNew.SessionRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ServerNew.AddSessionRequest> __Marshaller_duplex_AddSessionRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ServerNew.AddSessionRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ServerNew.AddSessionReply> __Marshaller_duplex_AddSessionReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ServerNew.AddSessionReply.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ServerNew.LoadByShowRequest, global::ServerNew.SessionReply> __Method_SessionByShow = new grpc::Method<global::ServerNew.LoadByShowRequest, global::ServerNew.SessionReply>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "SessionByShow",
        __Marshaller_duplex_LoadByShowRequest,
        __Marshaller_duplex_SessionReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ServerNew.SessionLoadRequest, global::ServerNew.SessionReply> __Method_LoadSession = new grpc::Method<global::ServerNew.SessionLoadRequest, global::ServerNew.SessionReply>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "LoadSession",
        __Marshaller_duplex_SessionLoadRequest,
        __Marshaller_duplex_SessionReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ServerNew.SessionRequest, global::ServerNew.SessionReply> __Method_GetSessionInfo = new grpc::Method<global::ServerNew.SessionRequest, global::ServerNew.SessionReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetSessionInfo",
        __Marshaller_duplex_SessionRequest,
        __Marshaller_duplex_SessionReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ServerNew.AddSessionRequest, global::ServerNew.AddSessionReply> __Method_AddSessionInfo = new grpc::Method<global::ServerNew.AddSessionRequest, global::ServerNew.AddSessionReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddSessionInfo",
        __Marshaller_duplex_AddSessionRequest,
        __Marshaller_duplex_AddSessionReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ServerNew.SessionReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of SendSession</summary>
    [grpc::BindServiceMethod(typeof(SendSession), "BindService")]
    public abstract partial class SendSessionBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task SessionByShow(global::ServerNew.LoadByShowRequest request, grpc::IServerStreamWriter<global::ServerNew.SessionReply> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task LoadSession(global::ServerNew.SessionLoadRequest request, grpc::IServerStreamWriter<global::ServerNew.SessionReply> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::ServerNew.SessionReply> GetSessionInfo(global::ServerNew.SessionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::ServerNew.AddSessionReply> AddSessionInfo(global::ServerNew.AddSessionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(SendSessionBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SessionByShow, serviceImpl.SessionByShow)
          .AddMethod(__Method_LoadSession, serviceImpl.LoadSession)
          .AddMethod(__Method_GetSessionInfo, serviceImpl.GetSessionInfo)
          .AddMethod(__Method_AddSessionInfo, serviceImpl.AddSessionInfo).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, SendSessionBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_SessionByShow, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::ServerNew.LoadByShowRequest, global::ServerNew.SessionReply>(serviceImpl.SessionByShow));
      serviceBinder.AddMethod(__Method_LoadSession, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::ServerNew.SessionLoadRequest, global::ServerNew.SessionReply>(serviceImpl.LoadSession));
      serviceBinder.AddMethod(__Method_GetSessionInfo, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ServerNew.SessionRequest, global::ServerNew.SessionReply>(serviceImpl.GetSessionInfo));
      serviceBinder.AddMethod(__Method_AddSessionInfo, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ServerNew.AddSessionRequest, global::ServerNew.AddSessionReply>(serviceImpl.AddSessionInfo));
    }

  }
}
#endregion
