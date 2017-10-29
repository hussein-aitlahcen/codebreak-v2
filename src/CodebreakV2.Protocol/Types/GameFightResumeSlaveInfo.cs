using System;
namespace CodebreakV2.Protocol.Types
{
	public class GameFightResumeSlaveInfo
	{
		public Double SlaveId { get; set; }
		public GameFightSpellCooldown[] SpellCooldowns { get; set; }
		public Byte SummonCount { get; set; }
		public Byte BombCount { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(SlaveId);
			for (var i = 0; i < SpellCooldowns.Length; i++)
			{
				SpellCooldowns[i].Serialize(writer);
			}
			writer.WriteByte(SummonCount);
			writer.WriteByte(BombCount);
		}
		public void Deserialize(IDataReader reader)
		{
			SlaveId = reader.ReadDouble();
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
