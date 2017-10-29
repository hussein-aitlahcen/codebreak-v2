using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeMultiCraftSetCrafterCanUseHisRessourcesMessage
	{
		public Boolean Allow { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(Allow);
		}
		public void Deserialize(IDataReader reader)
		{
			Allow = reader.ReadBoolean();
		}
	}
}
