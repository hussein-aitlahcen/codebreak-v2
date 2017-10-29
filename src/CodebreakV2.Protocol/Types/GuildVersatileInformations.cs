using System;
namespace CodebreakV2.Protocol.Types
{
	public class GuildVersatileInformations
	{
		public UInt32 GuildId { get; set; }
		public Int64 LeaderId { get; set; }
		public Byte GuildLevel { get; set; }
		public Byte NbMembers { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)GuildId);
			writer.WriteVarLong(LeaderId);
			writer.WriteByte(GuildLevel);
			writer.WriteByte(NbMembers);
		}
		public void Deserialize(IDataReader reader)
		{
			GuildId = (UInt32)reader.ReadVarInt();
			LeaderId = reader.ReadVarLong();
			GuildLevel = reader.ReadByte();
			NbMembers = reader.ReadByte();
		}
	}
}
