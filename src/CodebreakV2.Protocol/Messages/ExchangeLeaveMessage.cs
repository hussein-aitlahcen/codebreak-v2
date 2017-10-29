using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeLeaveMessage : LeaveDialogMessage
	{
		public Boolean Success { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteBoolean(Success);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Success = reader.ReadBoolean();
		}
	}
}
