using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class IdentificationFailedBannedMessage : IdentificationFailedMessage
	{
		public Double BanEndDate { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(BanEndDate);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			BanEndDate = reader.ReadDouble();
		}
	}
}
