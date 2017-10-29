using System;
namespace CodebreakV2.Protocol.Types
{
	public class FriendSpouseOnlineInformations : FriendSpouseInformations
	{
		public Double MapId { get; set; }
		public UInt16 SubAreaId { get; set; }
		public Boolean InFight { get; set; }
		public Boolean FollowSpouse { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			UInt32 wrappedBoolean = 0;
			writer.WriteDouble(MapId);
			writer.WriteVarShort((Int16)SubAreaId);
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, InFight);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 1, FollowSpouse);
			writer.WriteByte((Byte)wrappedBoolean);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			UInt32 wrappedBoolean = 0;
			MapId = reader.ReadDouble();
			SubAreaId = (UInt16)reader.ReadVarShort();
			wrappedBoolean = (UInt32)reader.ReadByte();
			InFight = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
			FollowSpouse = BooleanByteWrapper.GetFlag(wrappedBoolean, 1);
		}
	}
}
