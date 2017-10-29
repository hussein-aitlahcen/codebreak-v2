using System;
namespace CodebreakV2.Protocol.Types
{
	public class AllianceVersatileInformations
	{
		public UInt32 AllianceId { get; set; }
		public UInt16 NbGuilds { get; set; }
		public UInt16 NbMembers { get; set; }
		public UInt16 NbSubarea { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)AllianceId);
			writer.WriteVarShort((Int16)NbGuilds);
			writer.WriteVarShort((Int16)NbMembers);
			writer.WriteVarShort((Int16)NbSubarea);
		}
		public void Deserialize(IDataReader reader)
		{
			AllianceId = (UInt32)reader.ReadVarInt();
			NbGuilds = (UInt16)reader.ReadVarShort();
			NbMembers = (UInt16)reader.ReadVarShort();
			NbSubarea = (UInt16)reader.ReadVarShort();
		}
	}
}
