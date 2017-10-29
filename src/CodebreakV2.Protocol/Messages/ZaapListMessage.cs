using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ZaapListMessage : TeleportDestinationsListMessage
	{
		public Double SpawnMapId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(SpawnMapId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			SpawnMapId = reader.ReadDouble();
		}
	}
}
