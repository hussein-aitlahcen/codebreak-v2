using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class HavenBagDailyLoteryMessage
	{
		public Byte ReturnType { get; set; }
		public String TokenId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(ReturnType);
			writer.WriteUTF(TokenId);
		}
		public void Deserialize(IDataReader reader)
		{
			ReturnType = reader.ReadByte();
			TokenId = reader.ReadUTF();
		}
	}
}
