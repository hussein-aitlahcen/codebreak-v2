using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AchievementFinishedMessage
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
