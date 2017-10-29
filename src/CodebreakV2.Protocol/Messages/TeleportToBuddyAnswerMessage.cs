using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class TeleportToBuddyAnswerMessage
	{
		public UInt16 DungeonId { get; set; }
		public Int64 BuddyId { get; set; }
		public Boolean Accept { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)DungeonId);
			writer.WriteVarLong(BuddyId);
			writer.WriteBoolean(Accept);
		}
		public void Deserialize(IDataReader reader)
		{
			DungeonId = (UInt16)reader.ReadVarShort();
			BuddyId = reader.ReadVarLong();
			Accept = reader.ReadBoolean();
		}
	}
}
