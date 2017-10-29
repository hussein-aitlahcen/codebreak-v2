using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class CharacterCanBeCreatedResultMessage
	{
		public Boolean YesYouCan { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(YesYouCan);
		}
		public void Deserialize(IDataReader reader)
		{
			YesYouCan = reader.ReadBoolean();
		}
	}
}
