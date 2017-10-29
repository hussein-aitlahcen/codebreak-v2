using System;
namespace CodebreakV2.Protocol.Types
{
	public class PrismSubareaEmptyInfo
	{
		public UInt16 SubAreaId { get; set; }
		public UInt32 AllianceId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)SubAreaId);
			writer.WriteVarInt((Int32)AllianceId);
		}
		public void Deserialize(IDataReader reader)
		{
			SubAreaId = (UInt16)reader.ReadVarShort();
			AllianceId = (UInt32)reader.ReadVarInt();
		}
	}
}
