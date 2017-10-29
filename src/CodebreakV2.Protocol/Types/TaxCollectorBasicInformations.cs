using System;
namespace CodebreakV2.Protocol.Types
{
	public class TaxCollectorBasicInformations
	{
		public UInt16 FirstNameId { get; set; }
		public UInt16 LastNameId { get; set; }
		public Int16 WorldX { get; set; }
		public Int16 WorldY { get; set; }
		public Double MapId { get; set; }
		public UInt16 SubAreaId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)FirstNameId);
			writer.WriteVarShort((Int16)LastNameId);
			writer.WriteShort(WorldX);
			writer.WriteShort(WorldY);
			writer.WriteDouble(MapId);
			writer.WriteVarShort((Int16)SubAreaId);
		}
		public void Deserialize(IDataReader reader)
		{
			FirstNameId = (UInt16)reader.ReadVarShort();
			LastNameId = (UInt16)reader.ReadVarShort();
			WorldX = reader.ReadShort();
			WorldY = reader.ReadShort();
			MapId = reader.ReadDouble();
			SubAreaId = (UInt16)reader.ReadVarShort();
		}
	}
}
