// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: auth.proto
#pragma warning disable 1591
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace CodebreakV2.Shared.Intercom {
  public static partial class AuthService
  {
    static readonly string __ServiceName = "CodebreakV2.Shared.Intercom.AuthService";

    static readonly grpc::Marshaller<global::CodebreakV2.Shared.Intercom.BanRequest> __Marshaller_BanRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::CodebreakV2.Shared.Intercom.BanRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::CodebreakV2.Shared.Intercom.BanResponse> __Marshaller_BanResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::CodebreakV2.Shared.Intercom.BanResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::CodebreakV2.Shared.Intercom.BanRequest, global::CodebreakV2.Shared.Intercom.BanResponse> __Method_Ban = new grpc::Method<global::CodebreakV2.Shared.Intercom.BanRequest, global::CodebreakV2.Shared.Intercom.BanResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Ban",
        __Marshaller_BanRequest,
        __Marshaller_BanResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::CodebreakV2.Shared.Intercom.AuthReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of AuthService</summary>
    public abstract partial class AuthServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::CodebreakV2.Shared.Intercom.BanResponse> Ban(global::CodebreakV2.Shared.Intercom.BanRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for AuthService</summary>
    public partial class AuthServiceClient : grpc::ClientBase<AuthServiceClient>
    {
      /// <summary>Creates a new client for AuthService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public AuthServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for AuthService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public AuthServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected AuthServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected AuthServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::CodebreakV2.Shared.Intercom.BanResponse Ban(global::CodebreakV2.Shared.Intercom.BanRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Ban(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::CodebreakV2.Shared.Intercom.BanResponse Ban(global::CodebreakV2.Shared.Intercom.BanRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Ban, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::CodebreakV2.Shared.Intercom.BanResponse> BanAsync(global::CodebreakV2.Shared.Intercom.BanRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return BanAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::CodebreakV2.Shared.Intercom.BanResponse> BanAsync(global::CodebreakV2.Shared.Intercom.BanRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Ban, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override AuthServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AuthServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(AuthServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Ban, serviceImpl.Ban).Build();
    }

  }
}
#endregion