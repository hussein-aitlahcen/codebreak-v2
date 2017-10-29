using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameActionFightModifyEffectsDurationMessage : AbstractGameActionMessage
	{
		public Double TargetId { get; set; }
		public Int16 Delta { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(TargetId);
			writer.WriteShort(Delta);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			TargetId = reader.ReadDouble();
			Delta = reader.ReadShort();
		}
	}
}
