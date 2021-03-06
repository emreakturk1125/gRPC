// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/messageStreamingBiDirect.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace grpcMessageServerStreamingBiDirect {
  public static partial class MessageStreamingBiDirect
  {
    static readonly string __ServiceName = "streaming.MessageStreamingBiDirect";

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
    static readonly grpc::Marshaller<global::grpcMessageServerStreamingBiDirect.MessageStreamingBiDirectRequest> __Marshaller_streaming_MessageStreamingBiDirectRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::grpcMessageServerStreamingBiDirect.MessageStreamingBiDirectRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::grpcMessageServerStreamingBiDirect.MessageStreamingBiDirectResponse> __Marshaller_streaming_MessageStreamingBiDirectResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::grpcMessageServerStreamingBiDirect.MessageStreamingBiDirectResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::grpcMessageServerStreamingBiDirect.MessageStreamingBiDirectRequest, global::grpcMessageServerStreamingBiDirect.MessageStreamingBiDirectResponse> __Method_SendMessage = new grpc::Method<global::grpcMessageServerStreamingBiDirect.MessageStreamingBiDirectRequest, global::grpcMessageServerStreamingBiDirect.MessageStreamingBiDirectResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "SendMessage",
        __Marshaller_streaming_MessageStreamingBiDirectRequest,
        __Marshaller_streaming_MessageStreamingBiDirectResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::grpcMessageServerStreamingBiDirect.MessageStreamingBiDirectReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for MessageStreamingBiDirect</summary>
    public partial class MessageStreamingBiDirectClient : grpc::ClientBase<MessageStreamingBiDirectClient>
    {
      /// <summary>Creates a new client for MessageStreamingBiDirect</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public MessageStreamingBiDirectClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for MessageStreamingBiDirect that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public MessageStreamingBiDirectClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected MessageStreamingBiDirectClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected MessageStreamingBiDirectClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::grpcMessageServerStreamingBiDirect.MessageStreamingBiDirectRequest, global::grpcMessageServerStreamingBiDirect.MessageStreamingBiDirectResponse> SendMessage(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SendMessage(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::grpcMessageServerStreamingBiDirect.MessageStreamingBiDirectRequest, global::grpcMessageServerStreamingBiDirect.MessageStreamingBiDirectResponse> SendMessage(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_SendMessage, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override MessageStreamingBiDirectClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new MessageStreamingBiDirectClient(configuration);
      }
    }

  }
}
#endregion
