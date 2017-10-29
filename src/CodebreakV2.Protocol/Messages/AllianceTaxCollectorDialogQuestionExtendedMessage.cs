using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AllianceTaxCollectorDialogQuestionExtendedMessage : TaxCollectorDialogQuestionExtendedMessage
	{
		public BasicNamedAllianceInformations Alliance { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			Alliance.Serialize(writer);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Alliance = new BasicNamedAllianceInformations();
			Alliance.Deserialize(reader);
		}
	}
}
