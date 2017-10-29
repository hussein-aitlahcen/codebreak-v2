using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameActionFightThrowCharacterMessage : AbstractGameActionMessage
	{
		public Double TargetId { get; set; }
		public Int16 CellId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(TargetId);
			writer.WriteShort(CellId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			TargetId = reader.ReadDouble();
			CellId = reader.ReadShort();
		}
	}
}
