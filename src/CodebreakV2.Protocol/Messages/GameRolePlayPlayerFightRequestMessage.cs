using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameRolePlayPlayerFightRequestMessage
	{
		public Int64 TargetId { get; set; }
		public Int16 TargetCellId { get; set; }
		public Boolean Friendly { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(TargetId);
			writer.WriteShort(TargetCellId);
			writer.WriteBoolean(Friendly);
		}
		public void Deserialize(IDataReader reader)
		{
			TargetId = reader.ReadVarLong();
			TargetCellId = reader.ReadShort();
			Friendly = reader.ReadBoolean();
		}
	}
}
