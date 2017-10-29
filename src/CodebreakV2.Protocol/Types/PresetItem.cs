using System;
namespace CodebreakV2.Protocol.Types
{
	public class PresetItem
	{
		public Byte Position { get; set; }
		public UInt16 ObjGid { get; set; }
		public UInt32 ObjUid { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(Position);
			writer.WriteVarShort((Int16)ObjGid);
			writer.WriteVarInt((Int32)ObjUid);
		}
		public void Deserialize(IDataReader reader)
		{
			Position = reader.ReadByte();
			ObjGid = (UInt16)reader.ReadVarShort();
			ObjUid = (UInt32)reader.ReadVarInt();
		}
	}
}
