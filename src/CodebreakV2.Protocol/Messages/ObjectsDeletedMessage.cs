using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ObjectsDeletedMessage
	{
		public UInt32[] ObjectUID { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < ObjectUID.Length; i++)
			{
				writer.WriteVarInt((Int32)ObjectUID[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			ObjectUID = new UInt32[reader.ReadShort()];
			for (var i = 0; i < ObjectUID.Length; i++)
			{
				ObjectUID[i] = (UInt32)reader.ReadVarInt();
			}
		}
	}
}
