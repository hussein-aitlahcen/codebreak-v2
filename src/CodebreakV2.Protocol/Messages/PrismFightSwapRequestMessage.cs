using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PrismFightSwapRequestMessage
	{
		public UInt16 SubAreaId { get; set; }
		public Int64 TargetId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)SubAreaId);
			writer.WriteVarLong(TargetId);
		}
		public void Deserialize(IDataReader reader)
		{
			SubAreaId = (UInt16)reader.ReadVarShort();
			TargetId = reader.ReadVarLong();
		}
	}
}
