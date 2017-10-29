using System;
namespace CodebreakV2.Protocol.Types
{
	public class CharacterMinimalPlusLookAndGradeInformations : CharacterMinimalPlusLookInformations
	{
		public UInt32 Grade { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((Int32)Grade);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Grade = (UInt32)reader.ReadVarInt();
		}
	}
}
