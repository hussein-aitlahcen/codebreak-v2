using System;

namespace CodebreakV2.Protocol
{
    public interface IDataReader
    {
        UInt16 ReadUnsignedShort();
        UInt32 ReadUnsignedInt();
        UInt64 ReadUnsignedLong();
        Byte ReadByte();
        Int16 ReadShort();
        Int32 ReadInt();
        Int64 ReadLong();
        Single ReadFloat();
        Double ReadDouble();
        Int32 ReadVarInt();
        Int16 ReadVarShort();
        Int64 ReadVarLong();
        Boolean ReadBoolean();
        string ReadUTF();
    }
}