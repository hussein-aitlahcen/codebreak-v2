using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class TaxCollectorMovementAddMessage
	{
		public TaxCollectorInformations Informations { get; set; }
		public void Serialize(IDataWriter writer)
		{
			Informations.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			Informations = new TaxCollectorInformations();
			Informations.Deserialize(reader);
		}
	}
}
