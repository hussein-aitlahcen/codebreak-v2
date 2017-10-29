using System;
namespace CodebreakV2.Protocol.Types
{
	public class GuildFactSheetInformations : GuildInformations
	{
		public Int64 LeaderId { get; set; }
		public UInt16 NbMembers { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(LeaderId);
			writer.WriteVarShort((Int16)NbMembers);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			LeaderId = reader.ReadVarLong();
			NbMembers = (UInt16)reader.ReadVarShort();
		}
	}
}
