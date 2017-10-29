using System;
namespace CodebreakV2.Protocol.Types
{
	public class CharacterMinimalInformations : CharacterBasicMinimalInformations
	{
		public Byte Level { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(Level);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Level = reader.ReadByte();
		}
	}
}
