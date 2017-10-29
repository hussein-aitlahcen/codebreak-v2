using System;
namespace CodebreakV2.Protocol.Types
{
	public class HouseInformations
	{
		public UInt32 HouseId { get; set; }
		public UInt16 ModelId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)HouseId);
			writer.WriteVarShort((Int16)ModelId);
		}
		public void Deserialize(IDataReader reader)
		{
			HouseId = (UInt32)reader.ReadVarInt();
			ModelId = (UInt16)reader.ReadVarShort();
		}
	}
}
