using System;
namespace CodebreakV2.Protocol.Types
{
	public class AlliancePrismInformation : PrismInformation
	{
		public AllianceInformations Alliance { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			Alliance.Serialize(writer);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Alliance = new AllianceInformations();
			Alliance.Deserialize(reader);
		}
	}
}
