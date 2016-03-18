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
  public partial class WorkerResources : TBase
  {
    private double _mem_on_heap;
    private double _mem_off_heap;
    private double _cpu;

    public double Mem_on_heap
    {
      get
      {
        return _mem_on_heap;
      }
      set
      {
        __isset.mem_on_heap = true;
        this._mem_on_heap = value;
      }
    }

    public double Mem_off_heap
    {
      get
      {
        return _mem_off_heap;
      }
      set
      {
        __isset.mem_off_heap = true;
        this._mem_off_heap = value;
      }
    }

    public double Cpu
    {
      get
      {
        return _cpu;
      }
      set
      {
        __isset.cpu = true;
        this._cpu = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool mem_on_heap;
      public bool mem_off_heap;
      public bool cpu;
    }

    public WorkerResources() {
    }

    public void Read (TProtocol iprot)
    {
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
            if (field.Type == TType.Double) {
              Mem_on_heap = iprot.ReadDouble();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.Double) {
              Mem_off_heap = iprot.ReadDouble();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.Double) {
              Cpu = iprot.ReadDouble();
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
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("WorkerResources");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.mem_on_heap) {
        field.Name = "mem_on_heap";
        field.Type = TType.Double;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteDouble(Mem_on_heap);
        oprot.WriteFieldEnd();
      }
      if (__isset.mem_off_heap) {
        field.Name = "mem_off_heap";
        field.Type = TType.Double;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteDouble(Mem_off_heap);
        oprot.WriteFieldEnd();
      }
      if (__isset.cpu) {
        field.Name = "cpu";
        field.Type = TType.Double;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteDouble(Cpu);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("WorkerResources(");
      sb.Append("Mem_on_heap: ");
      sb.Append(Mem_on_heap);
      sb.Append(",Mem_off_heap: ");
      sb.Append(Mem_off_heap);
      sb.Append(",Cpu: ");
      sb.Append(Cpu);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
