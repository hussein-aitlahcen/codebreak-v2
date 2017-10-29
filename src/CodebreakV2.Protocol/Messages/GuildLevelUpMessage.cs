using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GuildLevelUpMessage
	{
		public Byte NewLevel { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(NewLevel);
		}
		public void Deserialize(IDataReader reader)
		{
			NewLevel = reader.ReadByte();
		}
	}
}
