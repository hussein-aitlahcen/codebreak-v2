using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeMultiCraftCrafterCanUseHisRessourcesMessage
	{
		public Boolean Allowed { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(Allowed);
		}
		public void Deserialize(IDataReader reader)
		{
			Allowed = reader.ReadBoolean();
		}
	}
}
