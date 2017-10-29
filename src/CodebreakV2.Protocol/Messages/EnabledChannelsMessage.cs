using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class EnabledChannelsMessage
	{
		public Byte[] Channels { get; set; }
		public Byte[] Disallowed { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Channels.Length; i++)
			{
				writer.WriteByte(Channels[i]);
			}
			for (var i = 0; i < Disallowed.Length; i++)
			{
				writer.WriteByte(Disallowed[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Channels = new Byte[reader.ReadShort()];
			for (var i = 0; i < Channels.Length; i++)
			{
				Channels[i] = reader.ReadByte();
			}
			Disallowed = new Byte[reader.ReadShort()];
			for (var i = 0; i < Disallowed.Length; i++)
			{
				Disallowed[i] = reader.ReadByte();
			}
		}
	}
}
