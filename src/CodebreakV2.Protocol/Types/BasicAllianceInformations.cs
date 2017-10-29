using System;
namespace CodebreakV2.Protocol.Types
{
	public class BasicAllianceInformations : AbstractSocialGroupInfos
	{
		public UInt32 AllianceId { get; set; }
		public String AllianceTag { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((Int32)AllianceId);
			writer.WriteUTF(AllianceTag);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			AllianceId = (UInt32)reader.ReadVarInt();
			AllianceTag = reader.ReadUTF();
		}
	}
}
