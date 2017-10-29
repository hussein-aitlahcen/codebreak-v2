using System;
namespace CodebreakV2.Protocol.Types
{
	public class CharacterMinimalGuildInformations : CharacterMinimalPlusLookInformations
	{
		public BasicGuildInformations Guild { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			Guild.Serialize(writer);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Guild = new BasicGuildInformations();
			Guild.Deserialize(reader);
		}
	}
}
