using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class UpdateLifePointsMessage
	{
		public UInt32 LifePoints { get; set; }
		public UInt32 MaxLifePoints { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)LifePoints);
			writer.WriteVarInt((Int32)MaxLifePoints);
		}
		public void Deserialize(IDataReader reader)
		{
			LifePoints = (UInt32)reader.ReadVarInt();
			MaxLifePoints = (UInt32)reader.ReadVarInt();
		}
	}
}
