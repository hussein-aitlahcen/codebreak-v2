using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class HelloConnectMessage
	{
		public String Salt { get; set; }
		public SByte[] Key { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(Salt);
			for (var i = 0; i < Key.Length; i++)
			{
				writer.WriteByte((Byte)Key[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Salt = reader.ReadUTF();
			Key = new SByte[reader.ReadVarInt()];
			for (var i = 0; i < Key.Length; i++)
			{
				Key[i] = (SByte)reader.ReadByte();
			}
		}
	}
}
