using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class IdentificationSuccessMessage
	{
		public String Login { get; set; }
		public String Nickname { get; set; }
		public UInt32 AccountId { get; set; }
		public Byte CommunityId { get; set; }
		public Boolean HasRights { get; set; }
		public String SecretQuestion { get; set; }
		public Double AccountCreation { get; set; }
		public Double SubscriptionElapsedDuration { get; set; }
		public Double SubscriptionEndDate { get; set; }
		public Boolean WasAlreadyConnected { get; set; }
		public Byte HavenbagAvailableRoom { get; set; }
		public void Serialize(IDataWriter writer)
		{
			UInt32 wrappedBoolean = 0;
			writer.WriteUTF(Login);
			writer.WriteUTF(Nickname);
			writer.WriteInt((Int32)AccountId);
			writer.WriteByte(CommunityId);
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, HasRights);
			writer.WriteByte((Byte)wrappedBoolean);
			writer.WriteUTF(SecretQuestion);
			writer.WriteDouble(AccountCreation);
			writer.WriteDouble(SubscriptionElapsedDuration);
			writer.WriteDouble(SubscriptionEndDate);
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, WasAlreadyConnected);
			writer.WriteByte((Byte)wrappedBoolean);
			writer.WriteByte(HavenbagAvailableRoom);
		}
		public void Deserialize(IDataReader reader)
		{
			UInt32 wrappedBoolean = 0;
			Login = reader.ReadUTF();
			Nickname = reader.ReadUTF();
			AccountId = (UInt32)reader.ReadInt();
			CommunityId = reader.ReadByte();
			wrappedBoolean = (UInt32)reader.ReadByte();
			HasRights = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
			SecretQuestion = reader.ReadUTF();
			AccountCreation = reader.ReadDouble();
			SubscriptionElapsedDuration = reader.ReadDouble();
			SubscriptionEndDate = reader.ReadDouble();
			wrappedBoolean = (UInt32)reader.ReadByte();
			WasAlreadyConnected = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
			HavenbagAvailableRoom = reader.ReadByte();
		}
	}
}
