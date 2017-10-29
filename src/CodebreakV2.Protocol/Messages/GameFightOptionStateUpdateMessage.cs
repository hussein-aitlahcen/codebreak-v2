using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameFightOptionStateUpdateMessage
	{
		public UInt16 FightId { get; set; }
		public Byte TeamId { get; set; }
		public Byte Option { get; set; }
		public Boolean State { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteShort((Int16)FightId);
			writer.WriteByte(TeamId);
			writer.WriteByte(Option);
			writer.WriteBoolean(State);
		}
		public void Deserialize(IDataReader reader)
		{
			FightId = (UInt16)reader.ReadShort();
			TeamId = reader.ReadByte();
			Option = reader.ReadByte();
			State = reader.ReadBoolean();
		}
	}
}
