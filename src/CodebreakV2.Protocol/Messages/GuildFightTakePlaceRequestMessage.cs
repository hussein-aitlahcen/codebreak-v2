using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GuildFightTakePlaceRequestMessage : GuildFightJoinRequestMessage
	{
		public Int32 ReplacedCharacterId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(ReplacedCharacterId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ReplacedCharacterId = reader.ReadInt();
		}
	}
}
