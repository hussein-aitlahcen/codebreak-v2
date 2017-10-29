using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PrismFightAddedMessage
	{
		public PrismFightersInformation Fight { get; set; }
		public void Serialize(IDataWriter writer)
		{
			Fight.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			Fight = new PrismFightersInformation();
			Fight.Deserialize(reader);
		}
	}
}
