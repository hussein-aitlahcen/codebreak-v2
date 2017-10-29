using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class CheckIntegrityMessage
	{
		public SByte[] Data { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Data.Length; i++)
			{
				writer.WriteByte((Byte)Data[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Data = new SByte[reader.ReadVarInt()];
			for (var i = 0; i < Data.Length; i++)
			{
				Data[i] = (SByte)reader.ReadByte();
			}
		}
	}
}
