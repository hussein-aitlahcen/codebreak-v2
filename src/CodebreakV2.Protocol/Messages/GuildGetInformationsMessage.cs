using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GuildGetInformationsMessage
	{
		public Byte InfoType { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(InfoType);
		}
		public void Deserialize(IDataReader reader)
		{
			InfoType = reader.ReadByte();
		}
	}
}
