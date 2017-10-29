using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PrismFightStateUpdateMessage
	{
		public Byte State { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(State);
		}
		public void Deserialize(IDataReader reader)
		{
			State = reader.ReadByte();
		}
	}
}
