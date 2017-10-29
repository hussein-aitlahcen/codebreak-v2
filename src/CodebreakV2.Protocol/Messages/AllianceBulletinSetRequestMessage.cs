using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AllianceBulletinSetRequestMessage : SocialNoticeSetRequestMessage
	{
		public String Content { get; set; }
		public Boolean NotifyMembers { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(Content);
			writer.WriteBoolean(NotifyMembers);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Content = reader.ReadUTF();
			NotifyMembers = reader.ReadBoolean();
		}
	}
}
