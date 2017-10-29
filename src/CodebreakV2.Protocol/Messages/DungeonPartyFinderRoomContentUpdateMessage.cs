using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class DungeonPartyFinderRoomContentUpdateMessage
	{
		public UInt16 DungeonId { get; set; }
		public DungeonPartyFinderPlayer[] AddedPlayers { get; set; }
		public Int64[] RemovedPlayersIds { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)DungeonId);
			for (var i = 0; i < AddedPlayers.Length; i++)
			{
				AddedPlayers[i].Serialize(writer);
			}
			for (var i = 0; i < RemovedPlayersIds.Length; i++)
			{
				writer.WriteVarLong(RemovedPlayersIds[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			DungeonId = (UInt16)reader.ReadVarShort();
			AddedPlayers = new DungeonPartyFinderPlayer[reader.ReadShort()];
			for (var i = 0; i < AddedPlayers.Length; i++)
			{
				(AddedPlayers[i] = new DungeonPartyFinderPlayer()).Deserialize(reader);
			}
			RemovedPlayersIds = new Int64[reader.ReadShort()];
			for (var i = 0; i < RemovedPlayersIds.Length; i++)
			{
				RemovedPlayersIds[i] = reader.ReadVarLong();
			}
		}
	}
}
