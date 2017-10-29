using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class DungeonKeyRingUpdateMessage
	{
		public UInt16 DungeonId { get; set; }
		public Boolean Available { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)DungeonId);
			writer.WriteBoolean(Available);
		}
		public void Deserialize(IDataReader reader)
		{
			DungeonId = (UInt16)reader.ReadVarShort();
			Available = reader.ReadBoolean();
		}
	}
}
