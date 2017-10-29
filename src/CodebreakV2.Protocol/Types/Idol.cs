using System;
namespace CodebreakV2.Protocol.Types
{
	public class Idol
	{
		public UInt16 Id { get; set; }
		public UInt16 XpBonusPercent { get; set; }
		public UInt16 DropBonusPercent { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)Id);
			writer.WriteVarShort((Int16)XpBonusPercent);
			writer.WriteVarShort((Int16)DropBonusPercent);
		}
		public void Deserialize(IDataReader reader)
		{
			Id = (UInt16)reader.ReadVarShort();
			XpBonusPercent = (UInt16)reader.ReadVarShort();
			DropBonusPercent = (UInt16)reader.ReadVarShort();
		}
	}
}
