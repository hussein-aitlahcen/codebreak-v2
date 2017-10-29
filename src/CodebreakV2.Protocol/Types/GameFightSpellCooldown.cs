using System;
namespace CodebreakV2.Protocol.Types
{
	public class GameFightSpellCooldown
	{
		public Int32 SpellId { get; set; }
		public Byte Cooldown { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt(SpellId);
			writer.WriteByte(Cooldown);
		}
		public void Deserialize(IDataReader reader)
		{
			SpellId = reader.ReadInt();
			Cooldown = reader.ReadByte();
		}
	}
}
