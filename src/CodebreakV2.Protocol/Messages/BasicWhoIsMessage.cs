using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class BasicWhoIsMessage
	{
		public Boolean Self { get; set; }
		public SByte Position { get; set; }
		public String AccountNickname { get; set; }
		public UInt32 AccountId { get; set; }
		public String PlayerName { get; set; }
		public Int64 PlayerId { get; set; }
		public Int16 AreaId { get; set; }
		public Int16 ServerId { get; set; }
		public Int16 OriginServerId { get; set; }
		public AbstractSocialGroupInfos[] SocialGroups { get; set; }
		public Boolean Verbose { get; set; }
		public Byte PlayerState { get; set; }
		public void Serialize(IDataWriter writer)
		{
			UInt32 wrappedBoolean = 0;
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, Self);
			writer.WriteByte((Byte)wrappedBoolean);
			writer.WriteByte((Byte)Position);
			writer.WriteUTF(AccountNickname);
			writer.WriteInt((Int32)AccountId);
			writer.WriteUTF(PlayerName);
			writer.WriteVarLong(PlayerId);
			writer.WriteShort(AreaId);
			writer.WriteShort(ServerId);
			writer.WriteShort(OriginServerId);
			for (var i = 0; i < SocialGroups.Length; i++)
			{
				SocialGroups[i].Serialize(writer);
			}
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, Verbose);
			writer.WriteByte((Byte)wrappedBoolean);
			writer.WriteByte(PlayerState);
		}
		public void Deserialize(IDataReader reader)
		{
			UInt32 wrappedBoolean = 0;
			wrappedBoolean = (UInt32)reader.ReadByte();
			Self = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
			Position = (SByte)reader.ReadByte();
			AccountNickname = reader.ReadUTF();
			AccountId = (UInt32)reader.ReadInt();
			PlayerName = reader.ReadUTF();
			PlayerId = reader.ReadVarLong();
			AreaId = reader.ReadShort();
			ServerId = reader.ReadShort();
			OriginServerId = reader.ReadShort();
			SocialGroups = new AbstractSocialGroupInfos[reader.ReadShort()];
			for (var i = 0; i < SocialGroups.Length; i++)
			{
				(SocialGroups[i] = new AbstractSocialGroupInfos()).Deserialize(reader);
			}
			wrappedBoolean = (UInt32)reader.ReadByte();
			Verbose = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
			PlayerState = reader.ReadByte();
		}
	}
}
