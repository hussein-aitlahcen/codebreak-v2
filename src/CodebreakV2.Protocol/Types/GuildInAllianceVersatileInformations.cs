using System;
namespace CodebreakV2.Protocol.Types
{
	public class GuildInAllianceVersatileInformations : GuildVersatileInformations
	{
		public UInt32 AllianceId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((Int32)AllianceId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			AllianceId = (UInt32)reader.ReadVarInt();
		}
	}
}
