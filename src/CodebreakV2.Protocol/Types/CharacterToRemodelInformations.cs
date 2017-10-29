using System;
namespace CodebreakV2.Protocol.Types
{
	public class CharacterToRemodelInformations : CharacterRemodelingInformation
	{
		public Byte PossibleChangeMask { get; set; }
		public Byte MandatoryChangeMask { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(PossibleChangeMask);
			writer.WriteByte(MandatoryChangeMask);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			PossibleChangeMask = reader.ReadByte();
			MandatoryChangeMask = reader.ReadByte();
		}
	}
}
