using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameFightRemoveTeamMemberMessage
	{
		public UInt16 FightId { get; set; }
		public Byte TeamId { get; set; }
		public Double CharId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteShort((Int16)FightId);
			writer.WriteByte(TeamId);
			writer.WriteDouble(CharId);
		}
		public void Deserialize(IDataReader reader)
		{
			FightId = (UInt16)reader.ReadShort();
			TeamId = reader.ReadByte();
			CharId = reader.ReadDouble();
		}
	}
}
