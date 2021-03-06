// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/messageStreamingCli.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace grpcMessageServerStreamingClient {
  public static partial class MessageStreamingCli
  {
    static readonly string __ServiceName = "streaming.MessageStreamingCli";

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
    static readonly grpc::Marshaller<global::grpcMessageServerStreamingClient.MessageStreamingCliRequest> __Marshaller_streaming_MessageStreamingCliRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::grpcMessageServerStreamingClient.MessageStreamingCliRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::grpcMessageServerStreamingClient.MessageStreamingCliResponse> __Marshaller_streaming_MessageStreamingCliResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::grpcMessageServerStreamingClient.MessageStreamingCliResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::grpcMessageServerStreamingClient.MessageStreamingCliRequest, global::grpcMessageServerStreamingClient.MessageStreamingCliResponse> __Method_SendMessage = new grpc::Method<global::grpcMessageServerStreamingClient.MessageStreamingCliRequest, global::grpcMessageServerStreamingClient.MessageStreamingCliResponse>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "SendMessage",
        __Marshaller_streaming_MessageStreamingCliRequest,
        __Marshaller_streaming_MessageStreamingCliResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::grpcMessageServerStreamingClient.MessageStreamingCliReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for MessageStreamingCli</summary>
    public partial class MessageStreamingCliClient : grpc::ClientBase<MessageStreamingCliClient>
    {
      /// <summary>Creates a new client for MessageStreamingCli</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public MessageStreamingCliClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for MessageStreamingCli that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public MessageStreamingCliClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected MessageStreamingCliClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected MessageStreamingCliClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncClientStreamingCall<global::grpcMessageServerStreamingClient.MessageStreamingCliRequest, global::grpcMessageServerStreamingClient.MessageStreamingCliResponse> SendMessage(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SendMessage(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncClientStreamingCall<global::grpcMessageServerStreamingClient.MessageStreamingCliRequest, global::grpcMessageServerStreamingClient.MessageStreamingCliResponse> SendMessage(grpc::CallOptions options)
      {
        return CallInvoker.AsyncClientStreamingCall(__Method_SendMessage, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override MessageStreamingCliClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new MessageStreamingCliClient(configuration);
      }
    }

  }
}
#endregion
