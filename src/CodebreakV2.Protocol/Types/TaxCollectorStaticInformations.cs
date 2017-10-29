using System;
namespace CodebreakV2.Protocol.Types
{
	public class TaxCollectorStaticInformations
	{
		public UInt16 FirstNameId { get; set; }
		public UInt16 LastNameId { get; set; }
		public GuildInformations GuildIdentity { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)FirstNameId);
			writer.WriteVarShort((Int16)LastNameId);
			GuildIdentity.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			FirstNameId = (UInt16)reader.ReadVarShort();
			LastNameId = (UInt16)reader.ReadVarShort();
			GuildIdentity = new GuildInformations();
			GuildIdentity.Deserialize(reader);
		}
	}
}
