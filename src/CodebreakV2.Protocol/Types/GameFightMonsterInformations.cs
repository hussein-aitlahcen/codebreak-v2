using System;
namespace CodebreakV2.Protocol.Types
{
	public class GameFightMonsterInformations : GameFightAIInformations
	{
		public UInt16 CreatureGenericId { get; set; }
		public Byte CreatureGrade { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((Int16)CreatureGenericId);
			writer.WriteByte(CreatureGrade);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			CreatureGenericId = (UInt16)reader.ReadVarShort();
			CreatureGrade = reader.ReadByte();
		}
	}
}
