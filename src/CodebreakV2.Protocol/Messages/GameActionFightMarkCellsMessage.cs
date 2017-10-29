using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameActionFightMarkCellsMessage : AbstractGameActionMessage
	{
		public GameActionMark Mark { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			Mark.Serialize(writer);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Mark = new GameActionMark();
			Mark.Deserialize(reader);
		}
	}
}
