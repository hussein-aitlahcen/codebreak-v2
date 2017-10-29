using System;
namespace CodebreakV2.Protocol.Types
{
	public class GameRolePlayGroupMonsterWaveInformations : GameRolePlayGroupMonsterInformations
	{
		public Byte NbWaves { get; set; }
		public GroupMonsterStaticInformations[] Alternatives { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(NbWaves);
			for (var i = 0; i < Alternatives.Length; i++)
			{
				Alternatives[i].Serialize(writer);
			}
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			NbWaves = reader.ReadByte();
			Alternatives = new GroupMonsterStaticInformations[reader.ReadShort()];
			for (var i = 0; i < Alternatives.Length; i++)
			{
				(Alternatives[i] = new GroupMonsterStaticInformations()).Deserialize(reader);
			}
		}
	}
}
