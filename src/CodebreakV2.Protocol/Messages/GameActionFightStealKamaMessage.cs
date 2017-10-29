using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameActionFightStealKamaMessage : AbstractGameActionMessage
	{
		public Double TargetId { get; set; }
		public Int64 Amount { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(TargetId);
			writer.WriteVarLong(Amount);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			TargetId = reader.ReadDouble();
			Amount = reader.ReadVarLong();
		}
	}
}
