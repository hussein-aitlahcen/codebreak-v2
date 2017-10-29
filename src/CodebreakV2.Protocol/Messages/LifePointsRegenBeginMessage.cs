using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class LifePointsRegenBeginMessage
	{
		public Byte RegenRate { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(RegenRate);
		}
		public void Deserialize(IDataReader reader)
		{
			RegenRate = reader.ReadByte();
		}
	}
}
