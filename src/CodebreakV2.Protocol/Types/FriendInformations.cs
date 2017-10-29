using System;
namespace CodebreakV2.Protocol.Types
{
	public class FriendInformations : AbstractContactInformations
	{
		public Byte PlayerState { get; set; }
		public UInt16 LastConnection { get; set; }
		public Int32 AchievementPoints { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(PlayerState);
			writer.WriteVarShort((Int16)LastConnection);
			writer.WriteInt(AchievementPoints);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			PlayerState = reader.ReadByte();
			LastConnection = (UInt16)reader.ReadVarShort();
			AchievementPoints = reader.ReadInt();
		}
	}
}
