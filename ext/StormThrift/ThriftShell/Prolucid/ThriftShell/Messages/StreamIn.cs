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

namespace Prolucid.ThriftShell.Messages
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class StreamIn : TBase
  {

    public string Id { get; set; }

    public string Comp { get; set; }

    public string Stream { get; set; }

    public int Task { get; set; }

    public List<Variant> Tuple { get; set; }

    public StreamIn() {
    }

    public StreamIn(string id, string comp, string stream, int task, List<Variant> tuple) : this() {
      this.Id = id;
      this.Comp = comp;
      this.Stream = stream;
      this.Task = task;
      this.Tuple = tuple;
    }

    public void Read (TProtocol iprot)
    {
      bool isset_id = false;
      bool isset_comp = false;
      bool isset_stream = false;
      bool isset_task = false;
      bool isset_tuple = false;
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
            if (field.Type == TType.String) {
              Id = iprot.ReadString();
              isset_id = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Comp = iprot.ReadString();
              isset_comp = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              Stream = iprot.ReadString();
              isset_stream = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              Task = iprot.ReadI32();
              isset_task = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.List) {
              {
                Tuple = new List<Variant>();
                TList _list10 = iprot.ReadListBegin();
                for( int _i11 = 0; _i11 < _list10.Count; ++_i11)
                {
                  Variant _elem12 = new Variant();
                  _elem12 = new Variant();
                  _elem12.Read(iprot);
                  Tuple.Add(_elem12);
                }
                iprot.ReadListEnd();
              }
              isset_tuple = true;
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
      if (!isset_id)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      if (!isset_comp)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      if (!isset_stream)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      if (!isset_task)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      if (!isset_tuple)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("StreamIn");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      field.Name = "id";
      field.Type = TType.String;
      field.ID = 1;
      oprot.WriteFieldBegin(field);
      oprot.WriteString(Id);
      oprot.WriteFieldEnd();
      field.Name = "comp";
      field.Type = TType.String;
      field.ID = 2;
      oprot.WriteFieldBegin(field);
      oprot.WriteString(Comp);
      oprot.WriteFieldEnd();
      field.Name = "stream";
      field.Type = TType.String;
      field.ID = 3;
      oprot.WriteFieldBegin(field);
      oprot.WriteString(Stream);
      oprot.WriteFieldEnd();
      field.Name = "task";
      field.Type = TType.I32;
      field.ID = 4;
      oprot.WriteFieldBegin(field);
      oprot.WriteI32(Task);
      oprot.WriteFieldEnd();
      field.Name = "tuple";
      field.Type = TType.List;
      field.ID = 5;
      oprot.WriteFieldBegin(field);
      {
        oprot.WriteListBegin(new TList(TType.Struct, Tuple.Count));
        foreach (Variant _iter13 in Tuple)
        {
          _iter13.Write(oprot);
        }
        oprot.WriteListEnd();
      }
      oprot.WriteFieldEnd();
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("StreamIn(");
      sb.Append("Id: ");
      sb.Append(Id);
      sb.Append(",Comp: ");
      sb.Append(Comp);
      sb.Append(",Stream: ");
      sb.Append(Stream);
      sb.Append(",Task: ");
      sb.Append(Task);
      sb.Append(",Tuple: ");
      sb.Append(Tuple);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
