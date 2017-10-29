using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GoldAddedMessage
	{
		public GoldItem Gold { get; set; }
		public void Serialize(IDataWriter writer)
		{
			Gold.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			Gold = new GoldItem();
			Gold.Deserialize(reader);
		}
	}
}
