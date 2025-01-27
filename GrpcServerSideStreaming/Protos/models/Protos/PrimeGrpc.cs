// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/prime.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcServerSideStreaming {
  /// <summary>
  /// The greeting service definition.
  /// </summary>
  public static partial class PrimeNumber
  {
    static readonly string __ServiceName = "prime.PrimeNumber";

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

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

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

    static readonly grpc::Marshaller<global::GrpcServerSideStreaming.PrimeManyTimeRequest> __Marshaller_prime_PrimeManyTimeRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcServerSideStreaming.PrimeManyTimeRequest.Parser));
    static readonly grpc::Marshaller<global::GrpcServerSideStreaming.PrimeManyTimeResposnce> __Marshaller_prime_PrimeManyTimeResposnce = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcServerSideStreaming.PrimeManyTimeResposnce.Parser));

    static readonly grpc::Method<global::GrpcServerSideStreaming.PrimeManyTimeRequest, global::GrpcServerSideStreaming.PrimeManyTimeResposnce> __Method_PrimeNumberMethod = new grpc::Method<global::GrpcServerSideStreaming.PrimeManyTimeRequest, global::GrpcServerSideStreaming.PrimeManyTimeResposnce>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "PrimeNumberMethod",
        __Marshaller_prime_PrimeManyTimeRequest,
        __Marshaller_prime_PrimeManyTimeResposnce);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcServerSideStreaming.PrimeReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of PrimeNumber</summary>
    [grpc::BindServiceMethod(typeof(PrimeNumber), "BindService")]
    public abstract partial class PrimeNumberBase
    {
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      public virtual global::System.Threading.Tasks.Task PrimeNumberMethod(global::GrpcServerSideStreaming.PrimeManyTimeRequest request, grpc::IServerStreamWriter<global::GrpcServerSideStreaming.PrimeManyTimeResposnce> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for PrimeNumber</summary>
    public partial class PrimeNumberClient : grpc::ClientBase<PrimeNumberClient>
    {
      /// <summary>Creates a new client for PrimeNumber</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public PrimeNumberClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for PrimeNumber that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public PrimeNumberClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected PrimeNumberClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected PrimeNumberClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::GrpcServerSideStreaming.PrimeManyTimeResposnce> PrimeNumberMethod(global::GrpcServerSideStreaming.PrimeManyTimeRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PrimeNumberMethod(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::GrpcServerSideStreaming.PrimeManyTimeResposnce> PrimeNumberMethod(global::GrpcServerSideStreaming.PrimeManyTimeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_PrimeNumberMethod, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override PrimeNumberClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new PrimeNumberClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(PrimeNumberBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_PrimeNumberMethod, serviceImpl.PrimeNumberMethod).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, PrimeNumberBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_PrimeNumberMethod, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::GrpcServerSideStreaming.PrimeManyTimeRequest, global::GrpcServerSideStreaming.PrimeManyTimeResposnce>(serviceImpl.PrimeNumberMethod));
    }

  }
}
#endregion
