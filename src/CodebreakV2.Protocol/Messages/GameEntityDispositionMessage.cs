using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameEntityDispositionMessage
	{
		public IdentifiedEntityDispositionInformations Disposition { get; set; }
		public void Serialize(IDataWriter writer)
		{
			Disposition.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			Disposition = new IdentifiedEntityDispositionInformations();
			Disposition.Deserialize(reader);
		}
	}
}
