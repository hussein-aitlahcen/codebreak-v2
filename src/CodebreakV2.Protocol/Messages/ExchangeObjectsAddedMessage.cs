using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeObjectsAddedMessage : ExchangeObjectMessage
	{
		public ObjectItem[] Object { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			for (var i = 0; i < Object.Length; i++)
			{
				Object[i].Serialize(writer);
			}
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Object = new ObjectItem[reader.ReadShort()];
			for (var i = 0; i < Object.Length; i++)
			{
				(Object[i] = new ObjectItem()).Deserialize(reader);
			}
		}
	}
}
