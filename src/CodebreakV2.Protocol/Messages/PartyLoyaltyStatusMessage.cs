using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PartyLoyaltyStatusMessage : AbstractPartyMessage
	{
		public Boolean Loyal { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteBoolean(Loyal);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Loyal = reader.ReadBoolean();
		}
	}
}
