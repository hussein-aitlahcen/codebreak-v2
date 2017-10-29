using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ObjectDeletedMessage
	{
		public UInt32 ObjectUID { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)ObjectUID);
		}
		public void Deserialize(IDataReader reader)
		{
			ObjectUID = (UInt32)reader.ReadVarInt();
		}
	}
}
