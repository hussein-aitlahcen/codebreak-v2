using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class TeleportBuddiesRequestedMessage
	{
		public UInt16 DungeonId { get; set; }
		public Int64 InviterId { get; set; }
		public Int64[] InvalidBuddiesIds { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)DungeonId);
			writer.WriteVarLong(InviterId);
			for (var i = 0; i < InvalidBuddiesIds.Length; i++)
			{
				writer.WriteVarLong(InvalidBuddiesIds[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			DungeonId = (UInt16)reader.ReadVarShort();
			InviterId = reader.ReadVarLong();
			InvalidBuddiesIds = new Int64[reader.ReadShort()];
			for (var i = 0; i < InvalidBuddiesIds.Length; i++)
			{
				InvalidBuddiesIds[i] = reader.ReadVarLong();
			}
		}
	}
}
