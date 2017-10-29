using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AllianceInvitedMessage
	{
		public Int64 RecruterId { get; set; }
		public String RecruterName { get; set; }
		public BasicNamedAllianceInformations AllianceInfo { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(RecruterId);
			writer.WriteUTF(RecruterName);
			AllianceInfo.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			RecruterId = reader.ReadVarLong();
			RecruterName = reader.ReadUTF();
			AllianceInfo = new BasicNamedAllianceInformations();
			AllianceInfo.Deserialize(reader);
		}
	}
}
