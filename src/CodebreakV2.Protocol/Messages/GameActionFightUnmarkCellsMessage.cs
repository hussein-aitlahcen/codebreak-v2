using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameActionFightUnmarkCellsMessage : AbstractGameActionMessage
	{
		public Int16 MarkId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort(MarkId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			MarkId = reader.ReadShort();
		}
	}
}
