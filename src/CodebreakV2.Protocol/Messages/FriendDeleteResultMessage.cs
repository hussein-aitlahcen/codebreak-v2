using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class FriendDeleteResultMessage
	{
		public Boolean Success { get; set; }
		public String Name { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(Success);
			writer.WriteUTF(Name);
		}
		public void Deserialize(IDataReader reader)
		{
			Success = reader.ReadBoolean();
			Name = reader.ReadUTF();
		}
	}
}
