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
  public partial class LogConfig : TBase
  {
    private Dictionary<string, LogLevel> _named_logger_level;

    public Dictionary<string, LogLevel> Named_logger_level
    {
      get
      {
        return _named_logger_level;
      }
      set
      {
        __isset.named_logger_level = true;
        this._named_logger_level = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool named_logger_level;
    }

    public LogConfig() {
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
          case 2:
            if (field.Type == TType.Map) {
              {
                Named_logger_level = new Dictionary<string, LogLevel>();
                TMap _map352 = iprot.ReadMapBegin();
                for( int _i353 = 0; _i353 < _map352.Count; ++_i353)
                {
                  string _key354;
                  LogLevel _val355;
                  _key354 = iprot.ReadString();
                  _val355 = new LogLevel();
                  _val355.Read(iprot);
                  Named_logger_level[_key354] = _val355;
                }
                iprot.ReadMapEnd();
              }
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
      TStruct struc = new TStruct("LogConfig");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Named_logger_level != null && __isset.named_logger_level) {
        field.Name = "named_logger_level";
        field.Type = TType.Map;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteMapBegin(new TMap(TType.String, TType.Struct, Named_logger_level.Count));
          foreach (string _iter356 in Named_logger_level.Keys)
          {
            oprot.WriteString(_iter356);
            Named_logger_level[_iter356].Write(oprot);
          }
          oprot.WriteMapEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("LogConfig(");
      sb.Append("Named_logger_level: ");
      sb.Append(Named_logger_level);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
