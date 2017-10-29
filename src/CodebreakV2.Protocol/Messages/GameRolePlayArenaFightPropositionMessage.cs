using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameRolePlayArenaFightPropositionMessage
	{
		public UInt32 FightId { get; set; }
		public Double[] AlliesId { get; set; }
		public UInt16 Duration { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt((Int32)FightId);
			for (var i = 0; i < AlliesId.Length; i++)
			{
				writer.WriteDouble(AlliesId[i]);
			}
			writer.WriteVarShort((Int16)Duration);
		}
		public void Deserialize(IDataReader reader)
		{
			FightId = (UInt32)reader.ReadInt();
			AlliesId = new Double[reader.ReadShort()];
			for (var i = 0; i < AlliesId.Length; i++)
			{
				AlliesId[i] = reader.ReadDouble();
			}
			Duration = (UInt16)reader.ReadVarShort();
		}
	}
}
