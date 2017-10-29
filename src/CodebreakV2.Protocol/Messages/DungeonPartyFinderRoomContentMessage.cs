using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class DungeonPartyFinderRoomContentMessage
	{
		public UInt16 DungeonId { get; set; }
		public DungeonPartyFinderPlayer[] Players { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)DungeonId);
			for (var i = 0; i < Players.Length; i++)
			{
				Players[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			DungeonId = (UInt16)reader.ReadVarShort();
			Players = new DungeonPartyFinderPlayer[reader.ReadShort()];
			for (var i = 0; i < Players.Length; i++)
			{
				(Players[i] = new DungeonPartyFinderPlayer()).Deserialize(reader);
			}
		}
	}
}
