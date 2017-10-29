using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AllianceInvitationMessage
	{
		public Int64 TargetId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(TargetId);
		}
		public void Deserialize(IDataReader reader)
		{
			TargetId = reader.ReadVarLong();
		}
	}
}
