using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameContextRemoveElementWithEventMessage : GameContextRemoveElementMessage
	{
		public Byte ElementEventId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(ElementEventId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ElementEventId = reader.ReadByte();
		}
	}
}
