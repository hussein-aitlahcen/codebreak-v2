using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameEntitiesDispositionMessage
	{
		public IdentifiedEntityDispositionInformations[] Dispositions { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Dispositions.Length; i++)
			{
				Dispositions[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Dispositions = new IdentifiedEntityDispositionInformations[reader.ReadShort()];
			for (var i = 0; i < Dispositions.Length; i++)
			{
				(Dispositions[i] = new IdentifiedEntityDispositionInformations()).Deserialize(reader);
			}
		}
	}
}
