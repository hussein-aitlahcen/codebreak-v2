using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ClientUIOpenedMessage
	{
		public Byte Type { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(Type);
		}
		public void Deserialize(IDataReader reader)
		{
			Type = reader.ReadByte();
		}
	}
}
