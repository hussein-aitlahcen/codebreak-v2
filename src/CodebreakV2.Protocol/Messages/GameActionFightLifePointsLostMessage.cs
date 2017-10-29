using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameActionFightLifePointsLostMessage : AbstractGameActionMessage
	{
		public Double TargetId { get; set; }
		public UInt32 Loss { get; set; }
		public UInt32 PermanentDamages { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(TargetId);
			writer.WriteVarInt((Int32)Loss);
			writer.WriteVarInt((Int32)PermanentDamages);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			TargetId = reader.ReadDouble();
			Loss = (UInt32)reader.ReadVarInt();
			PermanentDamages = (UInt32)reader.ReadVarInt();
		}
	}
}
