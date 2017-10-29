using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class TeleportToBuddyOfferMessage
	{
		public UInt16 DungeonId { get; set; }
		public Int64 BuddyId { get; set; }
		public UInt32 TimeLeft { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)DungeonId);
			writer.WriteVarLong(BuddyId);
			writer.WriteVarInt((Int32)TimeLeft);
		}
		public void Deserialize(IDataReader reader)
		{
			DungeonId = (UInt16)reader.ReadVarShort();
			BuddyId = reader.ReadVarLong();
			TimeLeft = (UInt32)reader.ReadVarInt();
		}
	}
}
