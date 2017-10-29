using System;
namespace CodebreakV2.Protocol.Types
{
	public class CharacterHardcoreOrEpicInformations : CharacterBaseInformations
	{
		public Byte DeathState { get; set; }
		public UInt16 DeathCount { get; set; }
		public Byte DeathMaxLevel { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(DeathState);
			writer.WriteVarShort((Int16)DeathCount);
			writer.WriteByte(DeathMaxLevel);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			DeathState = reader.ReadByte();
			DeathCount = (UInt16)reader.ReadVarShort();
			DeathMaxLevel = reader.ReadByte();
		}
	}
}
