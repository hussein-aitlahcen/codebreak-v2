using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GuildCharacsUpgradeRequestMessage
	{
		public Byte CharaTypeTarget { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(CharaTypeTarget);
		}
		public void Deserialize(IDataReader reader)
		{
			CharaTypeTarget = reader.ReadByte();
		}
	}
}
