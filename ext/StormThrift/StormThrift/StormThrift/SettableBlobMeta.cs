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
  public partial class SettableBlobMeta : TBase
  {
    private int _replication_factor;

    public List<AccessControl> Acl { get; set; }

    public int Replication_factor
    {
      get
      {
        return _replication_factor;
      }
      set
      {
        __isset.replication_factor = true;
        this._replication_factor = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool replication_factor;
    }

    public SettableBlobMeta() {
    }

    public SettableBlobMeta(List<AccessControl> acl) : this() {
      this.Acl = acl;
    }

    public void Read (TProtocol iprot)
    {
      bool isset_acl = false;
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
            if (field.Type == TType.List) {
              {
                Acl = new List<AccessControl>();
                TList _list244 = iprot.ReadListBegin();
                for( int _i245 = 0; _i245 < _list244.Count; ++_i245)
                {
                  AccessControl _elem246 = new AccessControl();
                  _elem246 = new AccessControl();
                  _elem246.Read(iprot);
                  Acl.Add(_elem246);
                }
                iprot.ReadListEnd();
              }
              isset_acl = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              Replication_factor = iprot.ReadI32();
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
      if (!isset_acl)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("SettableBlobMeta");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      field.Name = "acl";
      field.Type = TType.List;
      field.ID = 1;
      oprot.WriteFieldBegin(field);
      {
        oprot.WriteListBegin(new TList(TType.Struct, Acl.Count));
        foreach (AccessControl _iter247 in Acl)
        {
          _iter247.Write(oprot);
        }
        oprot.WriteListEnd();
      }
      oprot.WriteFieldEnd();
      if (__isset.replication_factor) {
        field.Name = "replication_factor";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Replication_factor);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("SettableBlobMeta(");
      sb.Append("Acl: ");
      sb.Append(Acl);
      sb.Append(",Replication_factor: ");
      sb.Append(Replication_factor);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
