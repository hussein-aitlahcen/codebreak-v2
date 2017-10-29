using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameActionFightInvisibilityMessage : AbstractGameActionMessage
	{
		public Double TargetId { get; set; }
		public Byte State { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(TargetId);
			writer.WriteByte(State);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			TargetId = reader.ReadDouble();
			State = reader.ReadByte();
		}
	}
}
