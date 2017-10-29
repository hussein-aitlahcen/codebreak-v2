using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GuildPaddockRemovedMessage
	{
		public Double PaddockId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(PaddockId);
		}
		public void Deserialize(IDataReader reader)
		{
			PaddockId = reader.ReadDouble();
		}
	}
}
