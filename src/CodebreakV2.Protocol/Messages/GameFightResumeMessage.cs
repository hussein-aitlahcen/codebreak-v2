using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameFightResumeMessage : GameFightSpectateMessage
	{
		public GameFightSpellCooldown[] SpellCooldowns { get; set; }
		public Byte SummonCount { get; set; }
		public Byte BombCount { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			for (var i = 0; i < SpellCooldowns.Length; i++)
			{
				SpellCooldowns[i].Serialize(writer);
			}
			writer.WriteByte(SummonCount);
			writer.WriteByte(BombCount);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			SpellCooldowns = new GameFightSpellCooldown[reader.ReadShort()];
			for (var i = 0; i < SpellCooldowns.Length; i++)
			{
				(SpellCooldowns[i] = new GameFightSpellCooldown()).Deserialize(reader);
			}
			SummonCount = reader.ReadByte();
			BombCount = reader.ReadByte();
		}
	}
}
