using System;
namespace CodebreakV2.Protocol.Types
{
	public class BasicGuildInformations : AbstractSocialGroupInfos
	{
		public UInt32 GuildId { get; set; }
		public String GuildName { get; set; }
		public Byte GuildLevel { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((Int32)GuildId);
			writer.WriteUTF(GuildName);
			writer.WriteByte(GuildLevel);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			GuildId = (UInt32)reader.ReadVarInt();
			GuildName = reader.ReadUTF();
			GuildLevel = reader.ReadByte();
		}
	}
}
