using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class KrosmasterAuthTokenMessage
	{
		public String Token { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(Token);
		}
		public void Deserialize(IDataReader reader)
		{
			Token = reader.ReadUTF();
		}
	}
}
