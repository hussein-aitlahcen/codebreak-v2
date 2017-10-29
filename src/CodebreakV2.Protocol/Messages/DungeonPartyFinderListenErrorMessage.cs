using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class DungeonPartyFinderListenErrorMessage
	{
		public UInt16 DungeonId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)DungeonId);
		}
		public void Deserialize(IDataReader reader)
		{
			DungeonId = (UInt16)reader.ReadVarShort();
		}
	}
}
