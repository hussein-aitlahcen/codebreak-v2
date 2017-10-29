using System;
namespace CodebreakV2.Protocol.Types
{
	public class FriendSpouseInformations
	{
		public UInt32 SpouseAccountId { get; set; }
		public Int64 SpouseId { get; set; }
		public String SpouseName { get; set; }
		public Byte SpouseLevel { get; set; }
		public SByte Breed { get; set; }
		public SByte Sex { get; set; }
		public EntityLook SpouseEntityLook { get; set; }
		public GuildInformations GuildInfo { get; set; }
		public SByte AlignmentSide { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt((Int32)SpouseAccountId);
			writer.WriteVarLong(SpouseId);
			writer.WriteUTF(SpouseName);
			writer.WriteByte(SpouseLevel);
			writer.WriteByte((Byte)Breed);
			writer.WriteByte((Byte)Sex);
			SpouseEntityLook.Serialize(writer);
			GuildInfo.Serialize(writer);
			writer.WriteByte((Byte)AlignmentSide);
		}
		public void Deserialize(IDataReader reader)
		{
			SpouseAccountId = (UInt32)reader.ReadInt();
			SpouseId = reader.ReadVarLong();
			SpouseName = reader.ReadUTF();
			SpouseLevel = reader.ReadByte();
			Breed = (SByte)reader.ReadByte();
			Sex = (SByte)reader.ReadByte();
			SpouseEntityLook = new EntityLook();
			SpouseEntityLook.Deserialize(reader);
			GuildInfo = new GuildInformations();
			GuildInfo.Deserialize(reader);
			AlignmentSide = (SByte)reader.ReadByte();
		}
	}
}
