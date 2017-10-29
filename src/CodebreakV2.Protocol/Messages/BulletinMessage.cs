using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class BulletinMessage : SocialNoticeMessage
	{
		public UInt32 LastNotifiedTimestamp { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt((Int32)LastNotifiedTimestamp);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			LastNotifiedTimestamp = (UInt32)reader.ReadInt();
		}
	}
}
