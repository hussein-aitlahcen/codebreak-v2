using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class IdolPartyRefreshMessage
	{
		public PartyIdol PartyIdol { get; set; }
		public void Serialize(IDataWriter writer)
		{
			PartyIdol.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			PartyIdol = new PartyIdol();
			PartyIdol.Deserialize(reader);
		}
	}
}
