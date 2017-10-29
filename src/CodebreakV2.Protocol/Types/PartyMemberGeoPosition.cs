using System;
namespace CodebreakV2.Protocol.Types
{
	public class PartyMemberGeoPosition
	{
		public UInt32 MemberId { get; set; }
		public Int16 WorldX { get; set; }
		public Int16 WorldY { get; set; }
		public Double MapId { get; set; }
		public UInt16 SubAreaId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt((Int32)MemberId);
			writer.WriteShort(WorldX);
			writer.WriteShort(WorldY);
			writer.WriteDouble(MapId);
			writer.WriteVarShort((Int16)SubAreaId);
		}
		public void Deserialize(IDataReader reader)
		{
			MemberId = (UInt32)reader.ReadInt();
			WorldX = reader.ReadShort();
			WorldY = reader.ReadShort();
			MapId = reader.ReadDouble();
			SubAreaId = (UInt16)reader.ReadVarShort();
		}
	}
}
