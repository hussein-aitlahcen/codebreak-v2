using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class TaxCollectorMovementsOfflineMessage
	{
		public TaxCollectorMovement[] Movements { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Movements.Length; i++)
			{
				Movements[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Movements = new TaxCollectorMovement[reader.ReadShort()];
			for (var i = 0; i < Movements.Length; i++)
			{
				(Movements[i] = new TaxCollectorMovement()).Deserialize(reader);
			}
		}
	}
}
