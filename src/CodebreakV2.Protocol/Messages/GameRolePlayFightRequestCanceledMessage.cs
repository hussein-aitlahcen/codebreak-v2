using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameRolePlayFightRequestCanceledMessage
	{
		public Int32 FightId { get; set; }
		public Double SourceId { get; set; }
		public Double TargetId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt(FightId);
			writer.WriteDouble(SourceId);
			writer.WriteDouble(TargetId);
		}
		public void Deserialize(IDataReader reader)
		{
			FightId = reader.ReadInt();
			SourceId = reader.ReadDouble();
			TargetId = reader.ReadDouble();
		}
	}
}
