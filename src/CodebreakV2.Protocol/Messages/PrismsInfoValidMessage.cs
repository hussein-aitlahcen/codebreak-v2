using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PrismsInfoValidMessage
	{
		public PrismFightersInformation[] Fights { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Fights.Length; i++)
			{
				Fights[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Fights = new PrismFightersInformation[reader.ReadShort()];
			for (var i = 0; i < Fights.Length; i++)
			{
				(Fights[i] = new PrismFightersInformation()).Deserialize(reader);
			}
		}
	}
}
