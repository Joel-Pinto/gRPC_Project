// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/Theater.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ServerNew {
  public static partial class SendTheater
  {
    static readonly string __ServiceName = "SendTheater";

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
    static readonly grpc::Marshaller<global::ServerNew.TheaterLoadRequest> __Marshaller_TheaterLoadRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ServerNew.TheaterLoadRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ServerNew.TheaterReply> __Marshaller_TheaterReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ServerNew.TheaterReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ServerNew.TheaterRequest> __Marshaller_TheaterRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ServerNew.TheaterRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ServerNew.AddTheaterRequest> __Marshaller_AddTheaterRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ServerNew.AddTheaterRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ServerNew.AddTheaterReply> __Marshaller_AddTheaterReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ServerNew.AddTheaterReply.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ServerNew.TheaterLoadRequest, global::ServerNew.TheaterReply> __Method_LoadTheater = new grpc::Method<global::ServerNew.TheaterLoadRequest, global::ServerNew.TheaterReply>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "LoadTheater",
        __Marshaller_TheaterLoadRequest,
        __Marshaller_TheaterReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ServerNew.TheaterRequest, global::ServerNew.TheaterReply> __Method_GetTheaterInfo = new grpc::Method<global::ServerNew.TheaterRequest, global::ServerNew.TheaterReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetTheaterInfo",
        __Marshaller_TheaterRequest,
        __Marshaller_TheaterReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ServerNew.AddTheaterRequest, global::ServerNew.AddTheaterReply> __Method_AddTheaterInfo = new grpc::Method<global::ServerNew.AddTheaterRequest, global::ServerNew.AddTheaterReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddTheaterInfo",
        __Marshaller_AddTheaterRequest,
        __Marshaller_AddTheaterReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ServerNew.TheaterReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of SendTheater</summary>
    [grpc::BindServiceMethod(typeof(SendTheater), "BindService")]
    public abstract partial class SendTheaterBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task LoadTheater(global::ServerNew.TheaterLoadRequest request, grpc::IServerStreamWriter<global::ServerNew.TheaterReply> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::ServerNew.TheaterReply> GetTheaterInfo(global::ServerNew.TheaterRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::ServerNew.AddTheaterReply> AddTheaterInfo(global::ServerNew.AddTheaterRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(SendTheaterBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_LoadTheater, serviceImpl.LoadTheater)
          .AddMethod(__Method_GetTheaterInfo, serviceImpl.GetTheaterInfo)
          .AddMethod(__Method_AddTheaterInfo, serviceImpl.AddTheaterInfo).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, SendTheaterBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_LoadTheater, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::ServerNew.TheaterLoadRequest, global::ServerNew.TheaterReply>(serviceImpl.LoadTheater));
      serviceBinder.AddMethod(__Method_GetTheaterInfo, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ServerNew.TheaterRequest, global::ServerNew.TheaterReply>(serviceImpl.GetTheaterInfo));
      serviceBinder.AddMethod(__Method_AddTheaterInfo, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ServerNew.AddTheaterRequest, global::ServerNew.AddTheaterReply>(serviceImpl.AddTheaterInfo));
    }

  }
}
#endregion
