// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto/packet/base_packet.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Proto {

  /// <summary>Holder for reflection information generated from Proto/packet/base_packet.proto</summary>
  public static partial class BasePacketReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto/packet/base_packet.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BasePacketReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5Qcm90by9wYWNrZXQvYmFzZV9wYWNrZXQucHJvdG8aInByb3RvL3BhY2tl",
            "dC9tZXNzYWdlL21lc3NhZ2UucHJvdG8iVQoKQmFzZVBhY2tldBIiCgxtZXNz",
            "YWdlX3R5cGUYASABKA4yDC5NZXNzYWdlVHlwZRIbCgdtZXNzYWdlGAIgASgL",
            "MgguTWVzc2FnZUgAQgYKBGRhdGEqJwoLTWVzc2FnZVR5cGUSCwoHVU5LTk9X",
            "ThAAEgsKB01FU1NBR0UQAUIUWgovZ2VuZXJhdGVkqgIFUHJvdG9iBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Proto.MessageReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Proto.MessageType), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Proto.BasePacket), global::Proto.BasePacket.Parser, new[]{ "MessageType", "Message" }, new[]{ "Data" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum MessageType {
    [pbr::OriginalName("UNKNOWN")] Unknown = 0,
    [pbr::OriginalName("MESSAGE")] Message = 1,
  }

  #endregion

  #region Messages
  public sealed partial class BasePacket : pb::IMessage<BasePacket>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BasePacket> _parser = new pb::MessageParser<BasePacket>(() => new BasePacket());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BasePacket> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Proto.BasePacketReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BasePacket() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BasePacket(BasePacket other) : this() {
      messageType_ = other.messageType_;
      switch (other.DataCase) {
        case DataOneofCase.Message:
          Message = other.Message.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BasePacket Clone() {
      return new BasePacket(this);
    }

    /// <summary>Field number for the "message_type" field.</summary>
    public const int MessageTypeFieldNumber = 1;
    private global::Proto.MessageType messageType_ = global::Proto.MessageType.Unknown;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Proto.MessageType MessageType {
      get { return messageType_; }
      set {
        messageType_ = value;
      }
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Proto.Message Message {
      get { return dataCase_ == DataOneofCase.Message ? (global::Proto.Message) data_ : null; }
      set {
        data_ = value;
        dataCase_ = value == null ? DataOneofCase.None : DataOneofCase.Message;
      }
    }

    private object data_;
    /// <summary>Enum of possible cases for the "data" oneof.</summary>
    public enum DataOneofCase {
      None = 0,
      Message = 2,
    }
    private DataOneofCase dataCase_ = DataOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DataOneofCase DataCase {
      get { return dataCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearData() {
      dataCase_ = DataOneofCase.None;
      data_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BasePacket);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BasePacket other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MessageType != other.MessageType) return false;
      if (!object.Equals(Message, other.Message)) return false;
      if (DataCase != other.DataCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MessageType != global::Proto.MessageType.Unknown) hash ^= MessageType.GetHashCode();
      if (dataCase_ == DataOneofCase.Message) hash ^= Message.GetHashCode();
      hash ^= (int) dataCase_;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (MessageType != global::Proto.MessageType.Unknown) {
        output.WriteRawTag(8);
        output.WriteEnum((int) MessageType);
      }
      if (dataCase_ == DataOneofCase.Message) {
        output.WriteRawTag(18);
        output.WriteMessage(Message);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (MessageType != global::Proto.MessageType.Unknown) {
        output.WriteRawTag(8);
        output.WriteEnum((int) MessageType);
      }
      if (dataCase_ == DataOneofCase.Message) {
        output.WriteRawTag(18);
        output.WriteMessage(Message);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (MessageType != global::Proto.MessageType.Unknown) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MessageType);
      }
      if (dataCase_ == DataOneofCase.Message) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Message);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BasePacket other) {
      if (other == null) {
        return;
      }
      if (other.MessageType != global::Proto.MessageType.Unknown) {
        MessageType = other.MessageType;
      }
      switch (other.DataCase) {
        case DataOneofCase.Message:
          if (Message == null) {
            Message = new global::Proto.Message();
          }
          Message.MergeFrom(other.Message);
          break;
      }

      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            MessageType = (global::Proto.MessageType) input.ReadEnum();
            break;
          }
          case 18: {
            global::Proto.Message subBuilder = new global::Proto.Message();
            if (dataCase_ == DataOneofCase.Message) {
              subBuilder.MergeFrom(Message);
            }
            input.ReadMessage(subBuilder);
            Message = subBuilder;
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            MessageType = (global::Proto.MessageType) input.ReadEnum();
            break;
          }
          case 18: {
            global::Proto.Message subBuilder = new global::Proto.Message();
            if (dataCase_ == DataOneofCase.Message) {
              subBuilder.MergeFrom(Message);
            }
            input.ReadMessage(subBuilder);
            Message = subBuilder;
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
