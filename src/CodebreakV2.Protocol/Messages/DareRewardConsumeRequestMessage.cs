using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class DareRewardConsumeRequestMessage
	{
		public Double DareId { get; set; }
		public Byte Type { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(DareId);
			writer.WriteByte(Type);
		}
		public void Deserialize(IDataReader reader)
		{
			DareId = reader.ReadDouble();
			Type = reader.ReadByte();
		}
	}
}
