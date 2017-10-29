using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PartyFollowThisMemberRequestMessage : PartyFollowMemberRequestMessage
	{
		public Boolean Enabled { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteBoolean(Enabled);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Enabled = reader.ReadBoolean();
		}
	}
}
