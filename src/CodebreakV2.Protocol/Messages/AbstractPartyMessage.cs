using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AbstractPartyMessage
	{
		public UInt32 PartyId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)PartyId);
		}
		public void Deserialize(IDataReader reader)
		{
			PartyId = (UInt32)reader.ReadVarInt();
		}
	}
}
