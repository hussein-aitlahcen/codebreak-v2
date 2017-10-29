using System;
namespace CodebreakV2.Protocol.Types
{
	public class NamedPartyTeam
	{
		public Byte TeamId { get; set; }
		public String PartyName { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(TeamId);
			writer.WriteUTF(PartyName);
		}
		public void Deserialize(IDataReader reader)
		{
			TeamId = reader.ReadByte();
			PartyName = reader.ReadUTF();
		}
	}
}
