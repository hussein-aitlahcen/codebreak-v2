using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AllianceInvitationStateRecrutedMessage
	{
		public Byte InvitationState { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(InvitationState);
		}
		public void Deserialize(IDataReader reader)
		{
			InvitationState = reader.ReadByte();
		}
	}
}
