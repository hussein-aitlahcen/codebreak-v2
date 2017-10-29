using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ChannelEnablingMessage
	{
		public Byte Channel { get; set; }
		public Boolean Enable { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(Channel);
			writer.WriteBoolean(Enable);
		}
		public void Deserialize(IDataReader reader)
		{
			Channel = reader.ReadByte();
			Enable = reader.ReadBoolean();
		}
	}
}
