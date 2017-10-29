using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class InventoryContentMessage
	{
		public ObjectItem[] Objects { get; set; }
		public Int64 Kamas { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Objects.Length; i++)
			{
				Objects[i].Serialize(writer);
			}
			writer.WriteVarLong(Kamas);
		}
		public void Deserialize(IDataReader reader)
		{
			Objects = new ObjectItem[reader.ReadShort()];
			for (var i = 0; i < Objects.Length; i++)
			{
				(Objects[i] = new ObjectItem()).Deserialize(reader);
			}
			Kamas = reader.ReadVarLong();
		}
	}
}
