using System;
namespace CodebreakV2.Protocol.Types
{
	public class GameRolePlayMutantInformations : GameRolePlayHumanoidInformations
	{
		public UInt16 MonsterId { get; set; }
		public SByte PowerLevel { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((Int16)MonsterId);
			writer.WriteByte((Byte)PowerLevel);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			MonsterId = (UInt16)reader.ReadVarShort();
			PowerLevel = (SByte)reader.ReadByte();
		}
	}
}
