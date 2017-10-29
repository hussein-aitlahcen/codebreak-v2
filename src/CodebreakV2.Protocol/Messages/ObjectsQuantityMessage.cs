using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ObjectsQuantityMessage
	{
		public ObjectItemQuantity[] ObjectsUIDAndQty { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < ObjectsUIDAndQty.Length; i++)
			{
				ObjectsUIDAndQty[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			ObjectsUIDAndQty = new ObjectItemQuantity[reader.ReadShort()];
			for (var i = 0; i < ObjectsUIDAndQty.Length; i++)
			{
				(ObjectsUIDAndQty[i] = new ObjectItemQuantity()).Deserialize(reader);
			}
		}
	}
}
