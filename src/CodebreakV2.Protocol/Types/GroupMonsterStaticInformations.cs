using System;
namespace CodebreakV2.Protocol.Types
{
	public class GroupMonsterStaticInformations
	{
		public MonsterInGroupLightInformations MainCreatureLightInfos { get; set; }
		public MonsterInGroupInformations[] Underlings { get; set; }
		public void Serialize(IDataWriter writer)
		{
			MainCreatureLightInfos.Serialize(writer);
			for (var i = 0; i < Underlings.Length; i++)
			{
				Underlings[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			MainCreatureLightInfos = new MonsterInGroupLightInformations();
			MainCreatureLightInfos.Deserialize(reader);
			Underlings = new MonsterInGroupInformations[reader.ReadShort()];
			for (var i = 0; i < Underlings.Length; i++)
			{
				(Underlings[i] = new MonsterInGroupInformations()).Deserialize(reader);
			}
		}
	}
}
