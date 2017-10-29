using System;
namespace CodebreakV2.Protocol.Types
{
	public class GuildInsiderFactSheetInformations : GuildFactSheetInformations
	{
		public String LeaderName { get; set; }
		public UInt16 NbConnectedMembers { get; set; }
		public Byte NbTaxCollectors { get; set; }
		public UInt32 LastActivity { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(LeaderName);
			writer.WriteVarShort((Int16)NbConnectedMembers);
			writer.WriteByte(NbTaxCollectors);
			writer.WriteInt((Int32)LastActivity);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			LeaderName = reader.ReadUTF();
			NbConnectedMembers = (UInt16)reader.ReadVarShort();
			NbTaxCollectors = reader.ReadByte();
			LastActivity = (UInt32)reader.ReadInt();
		}
	}
}
