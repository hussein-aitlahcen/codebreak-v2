using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PrismsListRegisterMessage
	{
		public Byte Listen { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(Listen);
		}
		public void Deserialize(IDataReader reader)
		{
			Listen = reader.ReadByte();
		}
	}
}
