using System;
namespace CodebreakV2.Protocol.Types
{
	public class AchievementObjective
	{
		public UInt32 Id { get; set; }
		public UInt16 MaxValue { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)Id);
			writer.WriteVarShort((Int16)MaxValue);
		}
		public void Deserialize(IDataReader reader)
		{
			Id = (UInt32)reader.ReadVarInt();
			MaxValue = (UInt16)reader.ReadVarShort();
		}
	}
}
