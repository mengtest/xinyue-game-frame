//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: config/java_proto/UserModule.proto
namespace com.xinyue.network.message.impl.proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SignRequestModel")]
  public partial class SignRequestModel : global::ProtoBuf.IExtensible
  {
    public SignRequestModel() {}
    
    private long _RoleId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"RoleId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long RoleId
    {
      get { return _RoleId; }
      set { _RoleId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SignResponseModel")]
  public partial class SignResponseModel : global::ProtoBuf.IExtensible
  {
    public SignResponseModel() {}
    
    private bool _Result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}