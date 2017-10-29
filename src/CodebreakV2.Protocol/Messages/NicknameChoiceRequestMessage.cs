using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class NicknameChoiceRequestMessage
	{
		public String Nickname { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(Nickname);
		}
		public void Deserialize(IDataReader reader)
		{
			Nickname = reader.ReadUTF();
		}
	}
}
