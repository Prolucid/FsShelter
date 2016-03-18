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
  public partial class LogLevel : TBase
  {
    private string _target_log_level;
    private int _reset_log_level_timeout_secs;
    private long _reset_log_level_timeout_epoch;
    private string _reset_log_level;

    /// <summary>
    /// 
    /// <seealso cref="LogLevelAction"/>
    /// </summary>
    public LogLevelAction Action { get; set; }

    public string Target_log_level
    {
      get
      {
        return _target_log_level;
      }
      set
      {
        __isset.target_log_level = true;
        this._target_log_level = value;
      }
    }

    public int Reset_log_level_timeout_secs
    {
      get
      {
        return _reset_log_level_timeout_secs;
      }
      set
      {
        __isset.reset_log_level_timeout_secs = true;
        this._reset_log_level_timeout_secs = value;
      }
    }

    public long Reset_log_level_timeout_epoch
    {
      get
      {
        return _reset_log_level_timeout_epoch;
      }
      set
      {
        __isset.reset_log_level_timeout_epoch = true;
        this._reset_log_level_timeout_epoch = value;
      }
    }

    public string Reset_log_level
    {
      get
      {
        return _reset_log_level;
      }
      set
      {
        __isset.reset_log_level = true;
        this._reset_log_level = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool target_log_level;
      public bool reset_log_level_timeout_secs;
      public bool reset_log_level_timeout_epoch;
      public bool reset_log_level;
    }

    public LogLevel() {
    }

    public LogLevel(LogLevelAction action) : this() {
      this.Action = action;
    }

    public void Read (TProtocol iprot)
    {
      bool isset_action = false;
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
            if (field.Type == TType.I32) {
              Action = (LogLevelAction)iprot.ReadI32();
              isset_action = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Target_log_level = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              Reset_log_level_timeout_secs = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I64) {
              Reset_log_level_timeout_epoch = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.String) {
              Reset_log_level = iprot.ReadString();
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
      if (!isset_action)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("LogLevel");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      field.Name = "action";
      field.Type = TType.I32;
      field.ID = 1;
      oprot.WriteFieldBegin(field);
      oprot.WriteI32((int)Action);
      oprot.WriteFieldEnd();
      if (Target_log_level != null && __isset.target_log_level) {
        field.Name = "target_log_level";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Target_log_level);
        oprot.WriteFieldEnd();
      }
      if (__isset.reset_log_level_timeout_secs) {
        field.Name = "reset_log_level_timeout_secs";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Reset_log_level_timeout_secs);
        oprot.WriteFieldEnd();
      }
      if (__isset.reset_log_level_timeout_epoch) {
        field.Name = "reset_log_level_timeout_epoch";
        field.Type = TType.I64;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(Reset_log_level_timeout_epoch);
        oprot.WriteFieldEnd();
      }
      if (Reset_log_level != null && __isset.reset_log_level) {
        field.Name = "reset_log_level";
        field.Type = TType.String;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Reset_log_level);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("LogLevel(");
      sb.Append("Action: ");
      sb.Append(Action);
      sb.Append(",Target_log_level: ");
      sb.Append(Target_log_level);
      sb.Append(",Reset_log_level_timeout_secs: ");
      sb.Append(Reset_log_level_timeout_secs);
      sb.Append(",Reset_log_level_timeout_epoch: ");
      sb.Append(Reset_log_level_timeout_epoch);
      sb.Append(",Reset_log_level: ");
      sb.Append(Reset_log_level);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
