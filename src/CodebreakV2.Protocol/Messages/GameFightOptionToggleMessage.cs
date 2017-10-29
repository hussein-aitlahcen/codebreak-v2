using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameFightOptionToggleMessage
	{
		public Byte Option { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(Option);
		}
		public void Deserialize(IDataReader reader)
		{
			Option = reader.ReadByte();
		}
	}
}
