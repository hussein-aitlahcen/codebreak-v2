using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class JobBookSubscribeRequestMessage
	{
		public Byte[] JobIds { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < JobIds.Length; i++)
			{
				writer.WriteByte(JobIds[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			JobIds = new Byte[reader.ReadShort()];
			for (var i = 0; i < JobIds.Length; i++)
			{
				JobIds[i] = reader.ReadByte();
			}
		}
	}
}
