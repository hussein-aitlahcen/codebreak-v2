using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AllianceFactsRequestMessage
	{
		public UInt32 AllianceId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)AllianceId);
		}
		public void Deserialize(IDataReader reader)
		{
			AllianceId = (UInt32)reader.ReadVarInt();
		}
	}
}
