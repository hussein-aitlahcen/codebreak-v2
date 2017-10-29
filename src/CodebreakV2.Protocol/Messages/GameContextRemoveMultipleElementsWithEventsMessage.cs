using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameContextRemoveMultipleElementsWithEventsMessage : GameContextRemoveMultipleElementsMessage
	{
		public Byte[] ElementEventIds { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			for (var i = 0; i < ElementEventIds.Length; i++)
			{
				writer.WriteByte(ElementEventIds[i]);
			}
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ElementEventIds = new Byte[reader.ReadShort()];
			for (var i = 0; i < ElementEventIds.Length; i++)
			{
				ElementEventIds[i] = reader.ReadByte();
			}
		}
	}
}
