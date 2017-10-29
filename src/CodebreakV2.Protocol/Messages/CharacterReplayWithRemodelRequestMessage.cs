using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class CharacterReplayWithRemodelRequestMessage : CharacterReplayRequestMessage
	{
		public RemodelingInformation Remodel { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			Remodel.Serialize(writer);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Remodel = new RemodelingInformation();
			Remodel.Deserialize(reader);
		}
	}
}
