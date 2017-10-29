using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class NpcDialogCreationMessage
	{
		public Double MapId { get; set; }
		public Int32 NpcId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(MapId);
			writer.WriteInt(NpcId);
		}
		public void Deserialize(IDataReader reader)
		{
			MapId = reader.ReadDouble();
			NpcId = reader.ReadInt();
		}
	}
}
