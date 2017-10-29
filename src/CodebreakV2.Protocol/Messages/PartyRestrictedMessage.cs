using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PartyRestrictedMessage : AbstractPartyMessage
	{
		public Boolean Restricted { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteBoolean(Restricted);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Restricted = reader.ReadBoolean();
		}
	}
}
