using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class MountXpRatioMessage
	{
		public Byte Ratio { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(Ratio);
		}
		public void Deserialize(IDataReader reader)
		{
			Ratio = reader.ReadByte();
		}
	}
}
