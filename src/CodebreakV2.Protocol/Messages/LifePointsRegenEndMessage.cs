using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class LifePointsRegenEndMessage : UpdateLifePointsMessage
	{
		public UInt32 LifePointsGained { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((Int32)LifePointsGained);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			LifePointsGained = (UInt32)reader.ReadVarInt();
		}
	}
}
