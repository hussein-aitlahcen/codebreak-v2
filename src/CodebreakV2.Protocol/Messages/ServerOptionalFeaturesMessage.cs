using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ServerOptionalFeaturesMessage
	{
		public Byte[] Features { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Features.Length; i++)
			{
				writer.WriteByte(Features[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Features = new Byte[reader.ReadShort()];
			for (var i = 0; i < Features.Length; i++)
			{
				Features[i] = reader.ReadByte();
			}
		}
	}
}
