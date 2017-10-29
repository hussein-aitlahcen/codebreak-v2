using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameDataPaddockObjectAddMessage
	{
		public PaddockItem PaddockItemDescription { get; set; }
		public void Serialize(IDataWriter writer)
		{
			PaddockItemDescription.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			PaddockItemDescription = new PaddockItem();
			PaddockItemDescription.Deserialize(reader);
		}
	}
}
