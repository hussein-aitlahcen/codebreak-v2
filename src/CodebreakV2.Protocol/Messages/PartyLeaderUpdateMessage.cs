using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PartyLeaderUpdateMessage : AbstractPartyEventMessage
	{
		public Int64 PartyLeaderId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(PartyLeaderId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			PartyLeaderId = reader.ReadVarLong();
		}
	}
}
