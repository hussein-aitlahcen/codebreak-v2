using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class MountSetXpRatioRequestMessage
	{
		public Byte XpRatio { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(XpRatio);
		}
		public void Deserialize(IDataReader reader)
		{
			XpRatio = reader.ReadByte();
		}
	}
}
