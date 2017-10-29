using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameActionFightNoSpellCastMessage
	{
		public UInt32 SpellLevelId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)SpellLevelId);
		}
		public void Deserialize(IDataReader reader)
		{
			SpellLevelId = (UInt32)reader.ReadVarInt();
		}
	}
}
