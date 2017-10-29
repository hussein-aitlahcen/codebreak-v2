using System;
namespace CodebreakV2.Protocol.Types
{
	public class GameFightFighterTaxCollectorLightInformations : GameFightFighterLightInformations
	{
		public UInt16 FirstNameId { get; set; }
		public UInt16 LastNameId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((Int16)FirstNameId);
			writer.WriteVarShort((Int16)LastNameId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			FirstNameId = (UInt16)reader.ReadVarShort();
			LastNameId = (UInt16)reader.ReadVarShort();
		}
	}
}
