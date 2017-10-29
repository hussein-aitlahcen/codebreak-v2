using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameActionFightReflectDamagesMessage : AbstractGameActionMessage
	{
		public Double TargetId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(TargetId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			TargetId = reader.ReadDouble();
		}
	}
}
