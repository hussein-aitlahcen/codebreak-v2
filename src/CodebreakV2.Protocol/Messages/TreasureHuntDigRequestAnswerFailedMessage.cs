using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class TreasureHuntDigRequestAnswerFailedMessage : TreasureHuntDigRequestAnswerMessage
	{
		public Byte WrongFlagCount { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(WrongFlagCount);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			WrongFlagCount = reader.ReadByte();
		}
	}
}
