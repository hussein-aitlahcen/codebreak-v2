using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameActionFightActivateGlyphTrapMessage : AbstractGameActionMessage
	{
		public Int16 MarkId { get; set; }
		public Boolean Active { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort(MarkId);
			writer.WriteBoolean(Active);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			MarkId = reader.ReadShort();
			Active = reader.ReadBoolean();
		}
	}
}
