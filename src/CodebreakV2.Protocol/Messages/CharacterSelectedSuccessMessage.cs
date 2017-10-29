using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class CharacterSelectedSuccessMessage
	{
		public CharacterBaseInformations Infos { get; set; }
		public Boolean IsCollectingStats { get; set; }
		public void Serialize(IDataWriter writer)
		{
			Infos.Serialize(writer);
			writer.WriteBoolean(IsCollectingStats);
		}
		public void Deserialize(IDataReader reader)
		{
			Infos = new CharacterBaseInformations();
			Infos.Deserialize(reader);
			IsCollectingStats = reader.ReadBoolean();
		}
	}
}
