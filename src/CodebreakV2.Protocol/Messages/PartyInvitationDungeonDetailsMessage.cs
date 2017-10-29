using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PartyInvitationDungeonDetailsMessage : PartyInvitationDetailsMessage
	{
		public UInt16 DungeonId { get; set; }
		public Boolean[] PlayersDungeonReady { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((Int16)DungeonId);
			for (var i = 0; i < PlayersDungeonReady.Length; i++)
			{
				writer.WriteBoolean(PlayersDungeonReady[i]);
			}
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			DungeonId = (UInt16)reader.ReadVarShort();
			PlayersDungeonReady = new Boolean[reader.ReadShort()];
			for (var i = 0; i < PlayersDungeonReady.Length; i++)
			{
				PlayersDungeonReady[i] = reader.ReadBoolean();
			}
		}
	}
}
