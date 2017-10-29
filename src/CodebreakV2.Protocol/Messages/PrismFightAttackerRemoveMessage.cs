using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PrismFightAttackerRemoveMessage
	{
		public UInt16 SubAreaId { get; set; }
		public UInt16 FightId { get; set; }
		public Int64 FighterToRemoveId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)SubAreaId);
			writer.WriteVarShort((Int16)FightId);
			writer.WriteVarLong(FighterToRemoveId);
		}
		public void Deserialize(IDataReader reader)
		{
			SubAreaId = (UInt16)reader.ReadVarShort();
			FightId = (UInt16)reader.ReadVarShort();
			FighterToRemoveId = reader.ReadVarLong();
		}
	}
}
