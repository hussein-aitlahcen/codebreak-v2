using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameActionFightChangeLookMessage : AbstractGameActionMessage
	{
		public Double TargetId { get; set; }
		public EntityLook EntityLook { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(TargetId);
			EntityLook.Serialize(writer);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			TargetId = reader.ReadDouble();
			EntityLook = new EntityLook();
			EntityLook.Deserialize(reader);
		}
	}
}
