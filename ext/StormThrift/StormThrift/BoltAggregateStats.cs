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
  public partial class BoltAggregateStats : TBase
  {
    private double _execute_latency_ms;
    private double _process_latency_ms;
    private long _executed;
    private double _capacity;

    public double Execute_latency_ms
    {
      get
      {
        return _execute_latency_ms;
      }
      set
      {
        __isset.execute_latency_ms = true;
        this._execute_latency_ms = value;
      }
    }

    public double Process_latency_ms
    {
      get
      {
        return _process_latency_ms;
      }
      set
      {
        __isset.process_latency_ms = true;
        this._process_latency_ms = value;
      }
    }

    public long Executed
    {
      get
      {
        return _executed;
      }
      set
      {
        __isset.executed = true;
        this._executed = value;
      }
    }

    public double Capacity
    {
      get
      {
        return _capacity;
      }
      set
      {
        __isset.capacity = true;
        this._capacity = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool execute_latency_ms;
      public bool process_latency_ms;
      public bool executed;
      public bool capacity;
    }

    public BoltAggregateStats() {
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
              Execute_latency_ms = iprot.ReadDouble();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.Double) {
              Process_latency_ms = iprot.ReadDouble();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I64) {
              Executed = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.Double) {
              Capacity = iprot.ReadDouble();
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
      TStruct struc = new TStruct("BoltAggregateStats");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.execute_latency_ms) {
        field.Name = "execute_latency_ms";
        field.Type = TType.Double;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteDouble(Execute_latency_ms);
        oprot.WriteFieldEnd();
      }
      if (__isset.process_latency_ms) {
        field.Name = "process_latency_ms";
        field.Type = TType.Double;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteDouble(Process_latency_ms);
        oprot.WriteFieldEnd();
      }
      if (__isset.executed) {
        field.Name = "executed";
        field.Type = TType.I64;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(Executed);
        oprot.WriteFieldEnd();
      }
      if (__isset.capacity) {
        field.Name = "capacity";
        field.Type = TType.Double;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteDouble(Capacity);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("BoltAggregateStats(");
      sb.Append("Execute_latency_ms: ");
      sb.Append(Execute_latency_ms);
      sb.Append(",Process_latency_ms: ");
      sb.Append(Process_latency_ms);
      sb.Append(",Executed: ");
      sb.Append(Executed);
      sb.Append(",Capacity: ");
      sb.Append(Capacity);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
