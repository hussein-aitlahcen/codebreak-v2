using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AllianceJoinedMessage
	{
		public AllianceInformations AllianceInfo { get; set; }
		public Boolean Enabled { get; set; }
		public UInt32 LeadingGuildId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			AllianceInfo.Serialize(writer);
			writer.WriteBoolean(Enabled);
			writer.WriteVarInt((Int32)LeadingGuildId);
		}
		public void Deserialize(IDataReader reader)
		{
			AllianceInfo = new AllianceInformations();
			AllianceInfo.Deserialize(reader);
			Enabled = reader.ReadBoolean();
			LeadingGuildId = (UInt32)reader.ReadVarInt();
		}
	}
}
