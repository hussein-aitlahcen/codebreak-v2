using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PartyInvitationDungeonMessage : PartyInvitationMessage
	{
		public UInt16 DungeonId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((Int16)DungeonId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			DungeonId = (UInt16)reader.ReadVarShort();
		}
	}
}
