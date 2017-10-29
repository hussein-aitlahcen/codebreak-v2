using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameRolePlayShowActorWithEventMessage : GameRolePlayShowActorMessage
	{
		public Byte ActorEventId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(ActorEventId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ActorEventId = reader.ReadByte();
		}
	}
}
