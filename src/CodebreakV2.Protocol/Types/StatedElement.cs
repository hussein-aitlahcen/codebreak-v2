using System;
namespace CodebreakV2.Protocol.Types
{
	public class StatedElement
	{
		public UInt32 ElementId { get; set; }
		public UInt16 ElementCellId { get; set; }
		public UInt32 ElementState { get; set; }
		public Boolean OnCurrentMap { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt((Int32)ElementId);
			writer.WriteVarShort((Int16)ElementCellId);
			writer.WriteVarInt((Int32)ElementState);
			writer.WriteBoolean(OnCurrentMap);
		}
		public void Deserialize(IDataReader reader)
		{
			ElementId = (UInt32)reader.ReadInt();
			ElementCellId = (UInt16)reader.ReadVarShort();
			ElementState = (UInt32)reader.ReadVarInt();
			OnCurrentMap = reader.ReadBoolean();
		}
	}
}
