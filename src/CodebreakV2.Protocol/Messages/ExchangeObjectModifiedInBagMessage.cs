using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeObjectModifiedInBagMessage : ExchangeObjectMessage
	{
		public ObjectItem Object { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			Object.Serialize(writer);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Object = new ObjectItem();
			Object.Deserialize(reader);
		}
	}
}
