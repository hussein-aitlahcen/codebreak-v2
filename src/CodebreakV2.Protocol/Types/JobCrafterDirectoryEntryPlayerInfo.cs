using System;
namespace CodebreakV2.Protocol.Types
{
	public class JobCrafterDirectoryEntryPlayerInfo
	{
		public Int64 PlayerId { get; set; }
		public String PlayerName { get; set; }
		public SByte AlignmentSide { get; set; }
		public SByte Breed { get; set; }
		public Boolean Sex { get; set; }
		public Boolean IsInWorkshop { get; set; }
		public Int16 WorldX { get; set; }
		public Int16 WorldY { get; set; }
		public Double MapId { get; set; }
		public UInt16 SubAreaId { get; set; }
		public PlayerStatus Status { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(PlayerId);
			writer.WriteUTF(PlayerName);
			writer.WriteByte((Byte)AlignmentSide);
			writer.WriteByte((Byte)Breed);
			writer.WriteBoolean(Sex);
			writer.WriteBoolean(IsInWorkshop);
			writer.WriteShort(WorldX);
			writer.WriteShort(WorldY);
			writer.WriteDouble(MapId);
			writer.WriteVarShort((Int16)SubAreaId);
			Status.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			PlayerId = reader.ReadVarLong();
			PlayerName = reader.ReadUTF();
			AlignmentSide = (SByte)reader.ReadByte();
			Breed = (SByte)reader.ReadByte();
			Sex = reader.ReadBoolean();
			IsInWorkshop = reader.ReadBoolean();
			WorldX = reader.ReadShort();
			WorldY = reader.ReadShort();
			MapId = reader.ReadDouble();
			SubAreaId = (UInt16)reader.ReadVarShort();
			Status = new PlayerStatus();
			Status.Deserialize(reader);
		}
	}
}
