using System;
namespace CodebreakV2.Protocol.Types
{
	public class IgnoredOnlineInformations : IgnoredInformations
	{
		public Int64 PlayerId { get; set; }
		public String PlayerName { get; set; }
		public SByte Breed { get; set; }
		public Boolean Sex { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(PlayerId);
			writer.WriteUTF(PlayerName);
			writer.WriteByte((Byte)Breed);
			writer.WriteBoolean(Sex);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			PlayerId = reader.ReadVarLong();
			PlayerName = reader.ReadUTF();
			Breed = (SByte)reader.ReadByte();
			Sex = reader.ReadBoolean();
		}
	}
}
