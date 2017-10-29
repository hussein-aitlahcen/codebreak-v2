using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class StorageObjectsRemoveMessage
	{
		public UInt32[] ObjectUIDList { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < ObjectUIDList.Length; i++)
			{
				writer.WriteVarInt((Int32)ObjectUIDList[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			ObjectUIDList = new UInt32[reader.ReadShort()];
			for (var i = 0; i < ObjectUIDList.Length; i++)
			{
				ObjectUIDList[i] = (UInt32)reader.ReadVarInt();
			}
		}
	}
}
