using System;
namespace CodebreakV2.Protocol.Types
{
	public class TaxCollectorStaticExtendedInformations : TaxCollectorStaticInformations
	{
		public AllianceInformations AllianceIdentity { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			AllianceIdentity.Serialize(writer);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			AllianceIdentity = new AllianceInformations();
			AllianceIdentity.Deserialize(reader);
		}
	}
}
