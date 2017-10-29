using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class InventoryPresetItemUpdateRequestMessage
	{
		public Byte PresetId { get; set; }
		public Byte Position { get; set; }
		public UInt32 ObjUid { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(PresetId);
			writer.WriteByte(Position);
			writer.WriteVarInt((Int32)ObjUid);
		}
		public void Deserialize(IDataReader reader)
		{
			PresetId = reader.ReadByte();
			Position = reader.ReadByte();
			ObjUid = (UInt32)reader.ReadVarInt();
		}
	}
}
