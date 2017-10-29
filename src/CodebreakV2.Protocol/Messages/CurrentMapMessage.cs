using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class CurrentMapMessage
	{
		public Double MapId { get; set; }
		public String MapKey { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(MapId);
			writer.WriteUTF(MapKey);
		}
		public void Deserialize(IDataReader reader)
		{
			MapId = reader.ReadDouble();
			MapKey = reader.ReadUTF();
		}
	}
}
