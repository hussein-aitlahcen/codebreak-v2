using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class DownloadCurrentSpeedMessage
	{
		public Byte DownloadSpeed { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(DownloadSpeed);
		}
		public void Deserialize(IDataReader reader)
		{
			DownloadSpeed = reader.ReadByte();
		}
	}
}
