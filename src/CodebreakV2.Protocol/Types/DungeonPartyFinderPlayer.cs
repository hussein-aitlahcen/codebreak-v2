using System;
namespace CodebreakV2.Protocol.Types
{
	public class DungeonPartyFinderPlayer
	{
		public Int64 PlayerId { get; set; }
		public String PlayerName { get; set; }
		public SByte Breed { get; set; }
		public Boolean Sex { get; set; }
		public Byte Level { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(PlayerId);
			writer.WriteUTF(PlayerName);
			writer.WriteByte((Byte)Breed);
			writer.WriteBoolean(Sex);
			writer.WriteByte(Level);
		}
		public void Deserialize(IDataReader reader)
		{
			PlayerId = reader.ReadVarLong();
			PlayerName = reader.ReadUTF();
			Breed = (SByte)reader.ReadByte();
			Sex = reader.ReadBoolean();
			Level = reader.ReadByte();
		}
	}
}
