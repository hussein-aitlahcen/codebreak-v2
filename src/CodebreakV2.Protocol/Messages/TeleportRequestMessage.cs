using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class TeleportRequestMessage
	{
		public Byte TeleporterType { get; set; }
		public Double MapId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(TeleporterType);
			writer.WriteDouble(MapId);
		}
		public void Deserialize(IDataReader reader)
		{
			TeleporterType = reader.ReadByte();
			MapId = reader.ReadDouble();
		}
	}
}
