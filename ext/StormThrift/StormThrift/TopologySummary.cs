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
  public partial class TopologySummary : TBase
  {
    private string _sched_status;
    private string _owner;
    private int _replication_count;
    private double _requested_memonheap;
    private double _requested_memoffheap;
    private double _requested_cpu;
    private double _assigned_memonheap;
    private double _assigned_memoffheap;
    private double _assigned_cpu;

    public string Id { get; set; }

    public string Name { get; set; }

    public int Num_tasks { get; set; }

    public int Num_executors { get; set; }

    public int Num_workers { get; set; }

    public int Uptime_secs { get; set; }

    public string Status { get; set; }

    public string Sched_status
    {
      get
      {
        return _sched_status;
      }
      set
      {
        __isset.sched_status = true;
        this._sched_status = value;
      }
    }

    public string Owner
    {
      get
      {
        return _owner;
      }
      set
      {
        __isset.owner = true;
        this._owner = value;
      }
    }

    public int Replication_count
    {
      get
      {
        return _replication_count;
      }
      set
      {
        __isset.replication_count = true;
        this._replication_count = value;
      }
    }

    public double Requested_memonheap
    {
      get
      {
        return _requested_memonheap;
      }
      set
      {
        __isset.requested_memonheap = true;
        this._requested_memonheap = value;
      }
    }

    public double Requested_memoffheap
    {
      get
      {
        return _requested_memoffheap;
      }
      set
      {
        __isset.requested_memoffheap = true;
        this._requested_memoffheap = value;
      }
    }

    public double Requested_cpu
    {
      get
      {
        return _requested_cpu;
      }
      set
      {
        __isset.requested_cpu = true;
        this._requested_cpu = value;
      }
    }

    public double Assigned_memonheap
    {
      get
      {
        return _assigned_memonheap;
      }
      set
      {
        __isset.assigned_memonheap = true;
        this._assigned_memonheap = value;
      }
    }

    public double Assigned_memoffheap
    {
      get
      {
        return _assigned_memoffheap;
      }
      set
      {
        __isset.assigned_memoffheap = true;
        this._assigned_memoffheap = value;
      }
    }

    public double Assigned_cpu
    {
      get
      {
        return _assigned_cpu;
      }
      set
      {
        __isset.assigned_cpu = true;
        this._assigned_cpu = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool sched_status;
      public bool owner;
      public bool replication_count;
      public bool requested_memonheap;
      public bool requested_memoffheap;
      public bool requested_cpu;
      public bool assigned_memonheap;
      public bool assigned_memoffheap;
      public bool assigned_cpu;
    }

    public TopologySummary() {
    }

    public TopologySummary(string id, string name, int num_tasks, int num_executors, int num_workers, int uptime_secs, string status) : this() {
      this.Id = id;
      this.Name = name;
      this.Num_tasks = num_tasks;
      this.Num_executors = num_executors;
      this.Num_workers = num_workers;
      this.Uptime_secs = uptime_secs;
      this.Status = status;
    }

    public void Read (TProtocol iprot)
    {
      bool isset_id = false;
      bool isset_name = false;
      bool isset_num_tasks = false;
      bool isset_num_executors = false;
      bool isset_num_workers = false;
      bool isset_uptime_secs = false;
      bool isset_status = false;
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
              Name = iprot.ReadString();
              isset_name = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              Num_tasks = iprot.ReadI32();
              isset_num_tasks = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              Num_executors = iprot.ReadI32();
              isset_num_executors = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I32) {
              Num_workers = iprot.ReadI32();
              isset_num_workers = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.I32) {
              Uptime_secs = iprot.ReadI32();
              isset_uptime_secs = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.String) {
              Status = iprot.ReadString();
              isset_status = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 513:
            if (field.Type == TType.String) {
              Sched_status = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 514:
            if (field.Type == TType.String) {
              Owner = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 515:
            if (field.Type == TType.I32) {
              Replication_count = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 521:
            if (field.Type == TType.Double) {
              Requested_memonheap = iprot.ReadDouble();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 522:
            if (field.Type == TType.Double) {
              Requested_memoffheap = iprot.ReadDouble();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 523:
            if (field.Type == TType.Double) {
              Requested_cpu = iprot.ReadDouble();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 524:
            if (field.Type == TType.Double) {
              Assigned_memonheap = iprot.ReadDouble();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 525:
            if (field.Type == TType.Double) {
              Assigned_memoffheap = iprot.ReadDouble();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 526:
            if (field.Type == TType.Double) {
              Assigned_cpu = iprot.ReadDouble();
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
      if (!isset_name)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      if (!isset_num_tasks)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      if (!isset_num_executors)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      if (!isset_num_workers)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      if (!isset_uptime_secs)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      if (!isset_status)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("TopologySummary");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      field.Name = "id";
      field.Type = TType.String;
      field.ID = 1;
      oprot.WriteFieldBegin(field);
      oprot.WriteString(Id);
      oprot.WriteFieldEnd();
      field.Name = "name";
      field.Type = TType.String;
      field.ID = 2;
      oprot.WriteFieldBegin(field);
      oprot.WriteString(Name);
      oprot.WriteFieldEnd();
      field.Name = "num_tasks";
      field.Type = TType.I32;
      field.ID = 3;
      oprot.WriteFieldBegin(field);
      oprot.WriteI32(Num_tasks);
      oprot.WriteFieldEnd();
      field.Name = "num_executors";
      field.Type = TType.I32;
      field.ID = 4;
      oprot.WriteFieldBegin(field);
      oprot.WriteI32(Num_executors);
      oprot.WriteFieldEnd();
      field.Name = "num_workers";
      field.Type = TType.I32;
      field.ID = 5;
      oprot.WriteFieldBegin(field);
      oprot.WriteI32(Num_workers);
      oprot.WriteFieldEnd();
      field.Name = "uptime_secs";
      field.Type = TType.I32;
      field.ID = 6;
      oprot.WriteFieldBegin(field);
      oprot.WriteI32(Uptime_secs);
      oprot.WriteFieldEnd();
      field.Name = "status";
      field.Type = TType.String;
      field.ID = 7;
      oprot.WriteFieldBegin(field);
      oprot.WriteString(Status);
      oprot.WriteFieldEnd();
      if (Sched_status != null && __isset.sched_status) {
        field.Name = "sched_status";
        field.Type = TType.String;
        field.ID = 513;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Sched_status);
        oprot.WriteFieldEnd();
      }
      if (Owner != null && __isset.owner) {
        field.Name = "owner";
        field.Type = TType.String;
        field.ID = 514;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Owner);
        oprot.WriteFieldEnd();
      }
      if (__isset.replication_count) {
        field.Name = "replication_count";
        field.Type = TType.I32;
        field.ID = 515;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Replication_count);
        oprot.WriteFieldEnd();
      }
      if (__isset.requested_memonheap) {
        field.Name = "requested_memonheap";
        field.Type = TType.Double;
        field.ID = 521;
        oprot.WriteFieldBegin(field);
        oprot.WriteDouble(Requested_memonheap);
        oprot.WriteFieldEnd();
      }
      if (__isset.requested_memoffheap) {
        field.Name = "requested_memoffheap";
        field.Type = TType.Double;
        field.ID = 522;
        oprot.WriteFieldBegin(field);
        oprot.WriteDouble(Requested_memoffheap);
        oprot.WriteFieldEnd();
      }
      if (__isset.requested_cpu) {
        field.Name = "requested_cpu";
        field.Type = TType.Double;
        field.ID = 523;
        oprot.WriteFieldBegin(field);
        oprot.WriteDouble(Requested_cpu);
        oprot.WriteFieldEnd();
      }
      if (__isset.assigned_memonheap) {
        field.Name = "assigned_memonheap";
        field.Type = TType.Double;
        field.ID = 524;
        oprot.WriteFieldBegin(field);
        oprot.WriteDouble(Assigned_memonheap);
        oprot.WriteFieldEnd();
      }
      if (__isset.assigned_memoffheap) {
        field.Name = "assigned_memoffheap";
        field.Type = TType.Double;
        field.ID = 525;
        oprot.WriteFieldBegin(field);
        oprot.WriteDouble(Assigned_memoffheap);
        oprot.WriteFieldEnd();
      }
      if (__isset.assigned_cpu) {
        field.Name = "assigned_cpu";
        field.Type = TType.Double;
        field.ID = 526;
        oprot.WriteFieldBegin(field);
        oprot.WriteDouble(Assigned_cpu);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("TopologySummary(");
      sb.Append("Id: ");
      sb.Append(Id);
      sb.Append(",Name: ");
      sb.Append(Name);
      sb.Append(",Num_tasks: ");
      sb.Append(Num_tasks);
      sb.Append(",Num_executors: ");
      sb.Append(Num_executors);
      sb.Append(",Num_workers: ");
      sb.Append(Num_workers);
      sb.Append(",Uptime_secs: ");
      sb.Append(Uptime_secs);
      sb.Append(",Status: ");
      sb.Append(Status);
      sb.Append(",Sched_status: ");
      sb.Append(Sched_status);
      sb.Append(",Owner: ");
      sb.Append(Owner);
      sb.Append(",Replication_count: ");
      sb.Append(Replication_count);
      sb.Append(",Requested_memonheap: ");
      sb.Append(Requested_memonheap);
      sb.Append(",Requested_memoffheap: ");
      sb.Append(Requested_memoffheap);
      sb.Append(",Requested_cpu: ");
      sb.Append(Requested_cpu);
      sb.Append(",Assigned_memonheap: ");
      sb.Append(Assigned_memonheap);
      sb.Append(",Assigned_memoffheap: ");
      sb.Append(Assigned_memoffheap);
      sb.Append(",Assigned_cpu: ");
      sb.Append(Assigned_cpu);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
