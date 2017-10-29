using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PrismFightJoinLeaveRequestMessage
	{
		public UInt16 SubAreaId { get; set; }
		public Boolean Join { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)SubAreaId);
			writer.WriteBoolean(Join);
		}
		public void Deserialize(IDataReader reader)
		{
			SubAreaId = (UInt16)reader.ReadVarShort();
			Join = reader.ReadBoolean();
		}
	}
}
