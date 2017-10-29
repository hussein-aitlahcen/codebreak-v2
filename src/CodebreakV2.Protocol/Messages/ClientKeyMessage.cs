using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ClientKeyMessage
	{
		public String Key { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(Key);
		}
		public void Deserialize(IDataReader reader)
		{
			Key = reader.ReadUTF();
		}
	}
}
