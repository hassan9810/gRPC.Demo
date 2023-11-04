// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/test.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace gRPC.Demo {
  public static partial class Test
  {
    static readonly string __ServiceName = "Test.Test";

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
    static readonly grpc::Marshaller<global::gRPC.Demo.CreateTestRequest> __Marshaller_Test_CreateTestRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPC.Demo.CreateTestRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRPC.Demo.CreateTestResponse> __Marshaller_Test_CreateTestResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPC.Demo.CreateTestResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRPC.Demo.ReadTestRequest> __Marshaller_Test_ReadTestRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPC.Demo.ReadTestRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRPC.Demo.ReadTestResponse> __Marshaller_Test_ReadTestResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPC.Demo.ReadTestResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRPC.Demo.GetAllRequest> __Marshaller_Test_GetAllRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPC.Demo.GetAllRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRPC.Demo.GetAllResponse> __Marshaller_Test_GetAllResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPC.Demo.GetAllResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRPC.Demo.UpdateTestRequest> __Marshaller_Test_UpdateTestRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPC.Demo.UpdateTestRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRPC.Demo.UpdateTestResponse> __Marshaller_Test_UpdateTestResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPC.Demo.UpdateTestResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRPC.Demo.DeleteTestRequest> __Marshaller_Test_DeleteTestRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPC.Demo.DeleteTestRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRPC.Demo.DeleteTestResponse> __Marshaller_Test_DeleteTestResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPC.Demo.DeleteTestResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::gRPC.Demo.CreateTestRequest, global::gRPC.Demo.CreateTestResponse> __Method_CreateTest = new grpc::Method<global::gRPC.Demo.CreateTestRequest, global::gRPC.Demo.CreateTestResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateTest",
        __Marshaller_Test_CreateTestRequest,
        __Marshaller_Test_CreateTestResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::gRPC.Demo.ReadTestRequest, global::gRPC.Demo.ReadTestResponse> __Method_GetTestById = new grpc::Method<global::gRPC.Demo.ReadTestRequest, global::gRPC.Demo.ReadTestResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetTestById",
        __Marshaller_Test_ReadTestRequest,
        __Marshaller_Test_ReadTestResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::gRPC.Demo.GetAllRequest, global::gRPC.Demo.GetAllResponse> __Method_GetAllTests = new grpc::Method<global::gRPC.Demo.GetAllRequest, global::gRPC.Demo.GetAllResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAllTests",
        __Marshaller_Test_GetAllRequest,
        __Marshaller_Test_GetAllResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::gRPC.Demo.UpdateTestRequest, global::gRPC.Demo.UpdateTestResponse> __Method_UpdateTest = new grpc::Method<global::gRPC.Demo.UpdateTestRequest, global::gRPC.Demo.UpdateTestResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateTest",
        __Marshaller_Test_UpdateTestRequest,
        __Marshaller_Test_UpdateTestResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::gRPC.Demo.DeleteTestRequest, global::gRPC.Demo.DeleteTestResponse> __Method_DeleteTest = new grpc::Method<global::gRPC.Demo.DeleteTestRequest, global::gRPC.Demo.DeleteTestResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteTest",
        __Marshaller_Test_DeleteTestRequest,
        __Marshaller_Test_DeleteTestResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::gRPC.Demo.TestReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Test</summary>
    [grpc::BindServiceMethod(typeof(Test), "BindService")]
    public abstract partial class TestBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::gRPC.Demo.CreateTestResponse> CreateTest(global::gRPC.Demo.CreateTestRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::gRPC.Demo.ReadTestResponse> GetTestById(global::gRPC.Demo.ReadTestRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::gRPC.Demo.GetAllResponse> GetAllTests(global::gRPC.Demo.GetAllRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::gRPC.Demo.UpdateTestResponse> UpdateTest(global::gRPC.Demo.UpdateTestRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::gRPC.Demo.DeleteTestResponse> DeleteTest(global::gRPC.Demo.DeleteTestRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(TestBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreateTest, serviceImpl.CreateTest)
          .AddMethod(__Method_GetTestById, serviceImpl.GetTestById)
          .AddMethod(__Method_GetAllTests, serviceImpl.GetAllTests)
          .AddMethod(__Method_UpdateTest, serviceImpl.UpdateTest)
          .AddMethod(__Method_DeleteTest, serviceImpl.DeleteTest).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, TestBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CreateTest, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::gRPC.Demo.CreateTestRequest, global::gRPC.Demo.CreateTestResponse>(serviceImpl.CreateTest));
      serviceBinder.AddMethod(__Method_GetTestById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::gRPC.Demo.ReadTestRequest, global::gRPC.Demo.ReadTestResponse>(serviceImpl.GetTestById));
      serviceBinder.AddMethod(__Method_GetAllTests, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::gRPC.Demo.GetAllRequest, global::gRPC.Demo.GetAllResponse>(serviceImpl.GetAllTests));
      serviceBinder.AddMethod(__Method_UpdateTest, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::gRPC.Demo.UpdateTestRequest, global::gRPC.Demo.UpdateTestResponse>(serviceImpl.UpdateTest));
      serviceBinder.AddMethod(__Method_DeleteTest, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::gRPC.Demo.DeleteTestRequest, global::gRPC.Demo.DeleteTestResponse>(serviceImpl.DeleteTest));
    }

  }
}
#endregion