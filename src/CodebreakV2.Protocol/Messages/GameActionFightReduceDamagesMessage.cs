using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameActionFightReduceDamagesMessage : AbstractGameActionMessage
	{
		public Double TargetId { get; set; }
		public UInt32 Amount { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(TargetId);
			writer.WriteVarInt((Int32)Amount);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			TargetId = reader.ReadDouble();
			Amount = (UInt32)reader.ReadVarInt();
		}
	}
}
