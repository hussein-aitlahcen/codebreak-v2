using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameActionFightSlideMessage : AbstractGameActionMessage
	{
		public Double TargetId { get; set; }
		public Int16 StartCellId { get; set; }
		public Int16 EndCellId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(TargetId);
			writer.WriteShort(StartCellId);
			writer.WriteShort(EndCellId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			TargetId = reader.ReadDouble();
			StartCellId = reader.ReadShort();
			EndCellId = reader.ReadShort();
		}
	}
}
