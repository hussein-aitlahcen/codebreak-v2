using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AbstractTaxCollectorListMessage
	{
		public TaxCollectorInformations[] Informations { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Informations.Length; i++)
			{
				Informations[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Informations = new TaxCollectorInformations[reader.ReadShort()];
			for (var i = 0; i < Informations.Length; i++)
			{
				(Informations[i] = new TaxCollectorInformations()).Deserialize(reader);
			}
		}
	}
}
