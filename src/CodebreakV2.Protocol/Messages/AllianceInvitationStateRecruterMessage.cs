using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AllianceInvitationStateRecruterMessage
	{
		public String RecrutedName { get; set; }
		public Byte InvitationState { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(RecrutedName);
			writer.WriteByte(InvitationState);
		}
		public void Deserialize(IDataReader reader)
		{
			RecrutedName = reader.ReadUTF();
			InvitationState = reader.ReadByte();
		}
	}
}
