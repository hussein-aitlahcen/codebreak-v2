using System;
namespace CodebreakV2.Protocol.Types
{
	public class BasicNamedAllianceInformations : BasicAllianceInformations
	{
		public String AllianceName { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(AllianceName);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			AllianceName = reader.ReadUTF();
		}
	}
}
