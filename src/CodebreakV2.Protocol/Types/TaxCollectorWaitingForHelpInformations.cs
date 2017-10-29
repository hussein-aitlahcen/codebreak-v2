using System;
namespace CodebreakV2.Protocol.Types
{
	public class TaxCollectorWaitingForHelpInformations : TaxCollectorComplementaryInformations
	{
		public ProtectedEntityWaitingForHelpInfo WaitingForHelpInfo { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			WaitingForHelpInfo.Serialize(writer);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			WaitingForHelpInfo = new ProtectedEntityWaitingForHelpInfo();
			WaitingForHelpInfo.Deserialize(reader);
		}
	}
}
