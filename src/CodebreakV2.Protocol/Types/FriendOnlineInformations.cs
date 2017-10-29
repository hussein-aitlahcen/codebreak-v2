using System;
namespace CodebreakV2.Protocol.Types
{
	public class FriendOnlineInformations : FriendInformations
	{
		public Int64 PlayerId { get; set; }
		public String PlayerName { get; set; }
		public Byte Level { get; set; }
		public SByte AlignmentSide { get; set; }
		public SByte Breed { get; set; }
		public Boolean Sex { get; set; }
		public GuildInformations GuildInfo { get; set; }
		public UInt16 MoodSmileyId { get; set; }
		public PlayerStatus Status { get; set; }
		public Boolean HavenBagShared { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			UInt32 wrappedBoolean = 0;
			writer.WriteVarLong(PlayerId);
			writer.WriteUTF(PlayerName);
			writer.WriteByte(Level);
			writer.WriteByte((Byte)AlignmentSide);
			writer.WriteByte((Byte)Breed);
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, Sex);
			writer.WriteByte((Byte)wrappedBoolean);
			GuildInfo.Serialize(writer);
			writer.WriteVarShort((Int16)MoodSmileyId);
			Status.Serialize(writer);
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, HavenBagShared);
			writer.WriteByte((Byte)wrappedBoolean);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			UInt32 wrappedBoolean = 0;
			PlayerId = reader.ReadVarLong();
			PlayerName = reader.ReadUTF();
			Level = reader.ReadByte();
			AlignmentSide = (SByte)reader.ReadByte();
			Breed = (SByte)reader.ReadByte();
			wrappedBoolean = (UInt32)reader.ReadByte();
			Sex = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
			GuildInfo = new GuildInformations();
			GuildInfo.Deserialize(reader);
			MoodSmileyId = (UInt16)reader.ReadVarShort();
			Status = new PlayerStatus();
			Status.Deserialize(reader);
			wrappedBoolean = (UInt32)reader.ReadByte();
			HavenBagShared = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
		}
	}
}
