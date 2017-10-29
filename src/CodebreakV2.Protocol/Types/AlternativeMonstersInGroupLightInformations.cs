using System;
namespace CodebreakV2.Protocol.Types
{
	public class AlternativeMonstersInGroupLightInformations
	{
		public Int32 PlayerCount { get; set; }
		public MonsterInGroupLightInformations[] Monsters { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt(PlayerCount);
			for (var i = 0; i < Monsters.Length; i++)
			{
				Monsters[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			PlayerCount = reader.ReadInt();
			Monsters = new MonsterInGroupLightInformations[reader.ReadShort()];
			for (var i = 0; i < Monsters.Length; i++)
			{
				(Monsters[i] = new MonsterInGroupLightInformations()).Deserialize(reader);
			}
		}
	}
}
