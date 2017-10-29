using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameActionFightLifePointsGainMessage : AbstractGameActionMessage
	{
		public Double TargetId { get; set; }
		public UInt32 Delta { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(TargetId);
			writer.WriteVarInt((Int32)Delta);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			TargetId = reader.ReadDouble();
			Delta = (UInt32)reader.ReadVarInt();
		}
	}
}
