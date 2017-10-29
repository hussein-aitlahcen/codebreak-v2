using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PartyFollowStatusUpdateMessage : AbstractPartyMessage
	{
		public Boolean Success { get; set; }
		public Boolean IsFollowed { get; set; }
		public Int64 FollowedId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			UInt32 wrappedBoolean = 0;
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, Success);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 1, IsFollowed);
			writer.WriteByte((Byte)wrappedBoolean);
			writer.WriteVarLong(FollowedId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			UInt32 wrappedBoolean = 0;
			wrappedBoolean = (UInt32)reader.ReadByte();
			Success = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
			IsFollowed = BooleanByteWrapper.GetFlag(wrappedBoolean, 1);
			FollowedId = reader.ReadVarLong();
		}
	}
}
