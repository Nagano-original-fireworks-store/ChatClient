// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto/packet/message/message.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Proto {

  /// <summary>Holder for reflection information generated from Proto/packet/message/message.proto</summary>
  public static partial class MessageReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto/packet/message/message.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJQcm90by9wYWNrZXQvbWVzc2FnZS9tZXNzYWdlLnByb3RvIjIKCkF0dGFj",
            "aG1lbnQSFgoOQXR0YWNobWVudE5hbWUYASABKAkSDAoERGF0YRgCIAEoDCKW",
            "AQoHTWVzc2FnZRIRCglNZXNzYWdlSWQYASABKAMSEAoIU2VuZFRpbWUYAiAB",
            "KAMSDgoGU2VuZElkGAMgASgDEhEKCVJlY2VpdmVJZBgEIAEoAxIMCgREYXRh",
            "GAUgASgMEhMKC01lc3NhZ2VUeXBlGAYgASgFEiAKC0F0dGFjaG1lbnRzGAcg",
            "AygLMgsuQXR0YWNobWVudEIjWhkvZ2VuZXJhdGVkL3BhY2tldC9tZXNzYWdl",
            "qgIFUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Proto.Attachment), global::Proto.Attachment.Parser, new[]{ "AttachmentName", "Data" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Proto.Message), global::Proto.Message.Parser, new[]{ "MessageId", "SendTime", "SendId", "ReceiveId", "Data", "MessageType", "Attachments" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Attachment : pb::IMessage<Attachment>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Attachment> _parser = new pb::MessageParser<Attachment>(() => new Attachment());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Attachment> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Proto.MessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Attachment() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Attachment(Attachment other) : this() {
      attachmentName_ = other.attachmentName_;
      data_ = other.data_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Attachment Clone() {
      return new Attachment(this);
    }

    /// <summary>Field number for the "AttachmentName" field.</summary>
    public const int AttachmentNameFieldNumber = 1;
    private string attachmentName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AttachmentName {
      get { return attachmentName_; }
      set {
        attachmentName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Data" field.</summary>
    public const int DataFieldNumber = 2;
    private pb::ByteString data_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString Data {
      get { return data_; }
      set {
        data_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Attachment);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Attachment other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AttachmentName != other.AttachmentName) return false;
      if (Data != other.Data) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AttachmentName.Length != 0) hash ^= AttachmentName.GetHashCode();
      if (Data.Length != 0) hash ^= Data.GetHashCode();
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
      if (AttachmentName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(AttachmentName);
      }
      if (Data.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(Data);
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
      if (AttachmentName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(AttachmentName);
      }
      if (Data.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(Data);
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
      if (AttachmentName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AttachmentName);
      }
      if (Data.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Data);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Attachment other) {
      if (other == null) {
        return;
      }
      if (other.AttachmentName.Length != 0) {
        AttachmentName = other.AttachmentName;
      }
      if (other.Data.Length != 0) {
        Data = other.Data;
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
          case 10: {
            AttachmentName = input.ReadString();
            break;
          }
          case 18: {
            Data = input.ReadBytes();
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
          case 10: {
            AttachmentName = input.ReadString();
            break;
          }
          case 18: {
            Data = input.ReadBytes();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class Message : pb::IMessage<Message>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Message> _parser = new pb::MessageParser<Message>(() => new Message());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Message> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Proto.MessageReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Message() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Message(Message other) : this() {
      messageId_ = other.messageId_;
      sendTime_ = other.sendTime_;
      sendId_ = other.sendId_;
      receiveId_ = other.receiveId_;
      data_ = other.data_;
      messageType_ = other.messageType_;
      attachments_ = other.attachments_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Message Clone() {
      return new Message(this);
    }

    /// <summary>Field number for the "MessageId" field.</summary>
    public const int MessageIdFieldNumber = 1;
    private long messageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long MessageId {
      get { return messageId_; }
      set {
        messageId_ = value;
      }
    }

    /// <summary>Field number for the "SendTime" field.</summary>
    public const int SendTimeFieldNumber = 2;
    private long sendTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long SendTime {
      get { return sendTime_; }
      set {
        sendTime_ = value;
      }
    }

    /// <summary>Field number for the "SendId" field.</summary>
    public const int SendIdFieldNumber = 3;
    private long sendId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long SendId {
      get { return sendId_; }
      set {
        sendId_ = value;
      }
    }

    /// <summary>Field number for the "ReceiveId" field.</summary>
    public const int ReceiveIdFieldNumber = 4;
    private long receiveId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long ReceiveId {
      get { return receiveId_; }
      set {
        receiveId_ = value;
      }
    }

    /// <summary>Field number for the "Data" field.</summary>
    public const int DataFieldNumber = 5;
    private pb::ByteString data_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString Data {
      get { return data_; }
      set {
        data_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "MessageType" field.</summary>
    public const int MessageTypeFieldNumber = 6;
    private int messageType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int MessageType {
      get { return messageType_; }
      set {
        messageType_ = value;
      }
    }

    /// <summary>Field number for the "Attachments" field.</summary>
    public const int AttachmentsFieldNumber = 7;
    private static readonly pb::FieldCodec<global::Proto.Attachment> _repeated_attachments_codec
        = pb::FieldCodec.ForMessage(58, global::Proto.Attachment.Parser);
    private readonly pbc::RepeatedField<global::Proto.Attachment> attachments_ = new pbc::RepeatedField<global::Proto.Attachment>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Proto.Attachment> Attachments {
      get { return attachments_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Message);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Message other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MessageId != other.MessageId) return false;
      if (SendTime != other.SendTime) return false;
      if (SendId != other.SendId) return false;
      if (ReceiveId != other.ReceiveId) return false;
      if (Data != other.Data) return false;
      if (MessageType != other.MessageType) return false;
      if(!attachments_.Equals(other.attachments_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MessageId != 0L) hash ^= MessageId.GetHashCode();
      if (SendTime != 0L) hash ^= SendTime.GetHashCode();
      if (SendId != 0L) hash ^= SendId.GetHashCode();
      if (ReceiveId != 0L) hash ^= ReceiveId.GetHashCode();
      if (Data.Length != 0) hash ^= Data.GetHashCode();
      if (MessageType != 0) hash ^= MessageType.GetHashCode();
      hash ^= attachments_.GetHashCode();
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
      if (MessageId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(MessageId);
      }
      if (SendTime != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(SendTime);
      }
      if (SendId != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(SendId);
      }
      if (ReceiveId != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(ReceiveId);
      }
      if (Data.Length != 0) {
        output.WriteRawTag(42);
        output.WriteBytes(Data);
      }
      if (MessageType != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(MessageType);
      }
      attachments_.WriteTo(output, _repeated_attachments_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (MessageId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(MessageId);
      }
      if (SendTime != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(SendTime);
      }
      if (SendId != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(SendId);
      }
      if (ReceiveId != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(ReceiveId);
      }
      if (Data.Length != 0) {
        output.WriteRawTag(42);
        output.WriteBytes(Data);
      }
      if (MessageType != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(MessageType);
      }
      attachments_.WriteTo(ref output, _repeated_attachments_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (MessageId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(MessageId);
      }
      if (SendTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(SendTime);
      }
      if (SendId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(SendId);
      }
      if (ReceiveId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ReceiveId);
      }
      if (Data.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Data);
      }
      if (MessageType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MessageType);
      }
      size += attachments_.CalculateSize(_repeated_attachments_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Message other) {
      if (other == null) {
        return;
      }
      if (other.MessageId != 0L) {
        MessageId = other.MessageId;
      }
      if (other.SendTime != 0L) {
        SendTime = other.SendTime;
      }
      if (other.SendId != 0L) {
        SendId = other.SendId;
      }
      if (other.ReceiveId != 0L) {
        ReceiveId = other.ReceiveId;
      }
      if (other.Data.Length != 0) {
        Data = other.Data;
      }
      if (other.MessageType != 0) {
        MessageType = other.MessageType;
      }
      attachments_.Add(other.attachments_);
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
            MessageId = input.ReadInt64();
            break;
          }
          case 16: {
            SendTime = input.ReadInt64();
            break;
          }
          case 24: {
            SendId = input.ReadInt64();
            break;
          }
          case 32: {
            ReceiveId = input.ReadInt64();
            break;
          }
          case 42: {
            Data = input.ReadBytes();
            break;
          }
          case 48: {
            MessageType = input.ReadInt32();
            break;
          }
          case 58: {
            attachments_.AddEntriesFrom(input, _repeated_attachments_codec);
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
            MessageId = input.ReadInt64();
            break;
          }
          case 16: {
            SendTime = input.ReadInt64();
            break;
          }
          case 24: {
            SendId = input.ReadInt64();
            break;
          }
          case 32: {
            ReceiveId = input.ReadInt64();
            break;
          }
          case 42: {
            Data = input.ReadBytes();
            break;
          }
          case 48: {
            MessageType = input.ReadInt32();
            break;
          }
          case 58: {
            attachments_.AddEntriesFrom(ref input, _repeated_attachments_codec);
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
