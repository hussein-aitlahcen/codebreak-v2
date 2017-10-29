using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameActionFightExchangePositionsMessage : AbstractGameActionMessage
	{
		public Double TargetId { get; set; }
		public Int16 CasterCellId { get; set; }
		public Int16 TargetCellId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(TargetId);
			writer.WriteShort(CasterCellId);
			writer.WriteShort(TargetCellId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			TargetId = reader.ReadDouble();
			CasterCellId = reader.ReadShort();
			TargetCellId = reader.ReadShort();
		}
	}
}
