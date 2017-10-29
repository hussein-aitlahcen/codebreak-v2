using System;
namespace CodebreakV2.Protocol.Types
{
	public class PaddockInstancesInformations : PaddockInformations
	{
		public PaddockBuyableInformations[] Paddocks { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			for (var i = 0; i < Paddocks.Length; i++)
			{
				Paddocks[i].Serialize(writer);
			}
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Paddocks = new PaddockBuyableInformations[reader.ReadShort()];
			for (var i = 0; i < Paddocks.Length; i++)
			{
				(Paddocks[i] = new PaddockBuyableInformations()).Deserialize(reader);
			}
		}
	}
}
