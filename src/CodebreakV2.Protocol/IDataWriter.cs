using System;

namespace CodebreakV2.Protocol
{
    public interface IDataWriter
    {
        void WriteByte(Byte value);
        void WriteShort(Int16 value);
        void WriteUnsignedShort(UInt16 value);
        void WriteUnsignedInt(UInt32 value);
        void WriteUnsignedLong(UInt64 value);
        void WriteInt(Int32 value);
        void WriteLong(Int64 value);
        void WriteFloat(Single value);
        void WriteDouble(Double value);
        void WriteVarInt(Int32 value);
        void WriteVarShort(Int16 value);
        void WriteVarLong(Int64 value);
        void WriteBoolean(Boolean value);
        void WriteUTF(string value);
    }
}