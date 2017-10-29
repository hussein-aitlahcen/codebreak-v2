using System;
namespace CodebreakV2.Protocol.Types
{
	public class MonsterBoosts
	{
		public UInt32 Id { get; set; }
		public UInt16 XpBoost { get; set; }
		public UInt16 DropBoost { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)Id);
			writer.WriteVarShort((Int16)XpBoost);
			writer.WriteVarShort((Int16)DropBoost);
		}
		public void Deserialize(IDataReader reader)
		{
			Id = (UInt32)reader.ReadVarInt();
			XpBoost = (UInt16)reader.ReadVarShort();
			DropBoost = (UInt16)reader.ReadVarShort();
		}
	}
}
