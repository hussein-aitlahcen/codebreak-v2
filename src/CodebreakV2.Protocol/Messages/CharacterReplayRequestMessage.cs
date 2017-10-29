using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class CharacterReplayRequestMessage
	{
		public Int64 CharacterId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(CharacterId);
		}
		public void Deserialize(IDataReader reader)
		{
			CharacterId = reader.ReadVarLong();
		}
	}
}
