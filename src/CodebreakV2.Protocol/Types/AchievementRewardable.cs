using System;
namespace CodebreakV2.Protocol.Types
{
	public class AchievementRewardable
	{
		public UInt16 Id { get; set; }
		public Byte Finishedlevel { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)Id);
			writer.WriteByte(Finishedlevel);
		}
		public void Deserialize(IDataReader reader)
		{
			Id = (UInt16)reader.ReadVarShort();
			Finishedlevel = reader.ReadByte();
		}
	}
}
