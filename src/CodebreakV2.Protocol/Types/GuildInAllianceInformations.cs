using System;
namespace CodebreakV2.Protocol.Types
{
	public class GuildInAllianceInformations : GuildInformations
	{
		public Byte NbMembers { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(NbMembers);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			NbMembers = reader.ReadByte();
		}
	}
}
