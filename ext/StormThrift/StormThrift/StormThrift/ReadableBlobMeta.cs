/**
 * Autogenerated by Thrift Compiler (0.9.1)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace StormThrift
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class ReadableBlobMeta : TBase
  {

    public SettableBlobMeta Settable { get; set; }

    public long Version { get; set; }

    public ReadableBlobMeta() {
    }

    public ReadableBlobMeta(SettableBlobMeta settable, long version) : this() {
      this.Settable = settable;
      this.Version = version;
    }

    public void Read (TProtocol iprot)
    {
      bool isset_settable = false;
      bool isset_version = false;
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.Struct) {
              Settable = new SettableBlobMeta();
              Settable.Read(iprot);
              isset_settable = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I64) {
              Version = iprot.ReadI64();
              isset_version = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
      if (!isset_settable)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      if (!isset_version)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("ReadableBlobMeta");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      field.Name = "settable";
      field.Type = TType.Struct;
      field.ID = 1;
      oprot.WriteFieldBegin(field);
      Settable.Write(oprot);
      oprot.WriteFieldEnd();
      field.Name = "version";
      field.Type = TType.I64;
      field.ID = 2;
      oprot.WriteFieldBegin(field);
      oprot.WriteI64(Version);
      oprot.WriteFieldEnd();
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ReadableBlobMeta(");
      sb.Append("Settable: ");
      sb.Append(Settable== null ? "<null>" : Settable.ToString());
      sb.Append(",Version: ");
      sb.Append(Version);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
