using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeCraftResultWithObjectDescMessage : ExchangeCraftResultMessage
	{
		public ObjectItemNotInContainer ObjectInfo { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			ObjectInfo.Serialize(writer);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ObjectInfo = new ObjectItemNotInContainer();
			ObjectInfo.Deserialize(reader);
		}
	}
}
