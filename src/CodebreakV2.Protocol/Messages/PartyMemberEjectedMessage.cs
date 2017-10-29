using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PartyMemberEjectedMessage : PartyMemberRemoveMessage
	{
		public Int64 KickerId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(KickerId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			KickerId = reader.ReadVarLong();
		}
	}
}
