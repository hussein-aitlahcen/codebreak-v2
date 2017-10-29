using System;
namespace CodebreakV2.Protocol.Types
{
	public class GroupMonsterStaticInformationsWithAlternatives : GroupMonsterStaticInformations
	{
		public AlternativeMonstersInGroupLightInformations[] Alternatives { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			for (var i = 0; i < Alternatives.Length; i++)
			{
				Alternatives[i].Serialize(writer);
			}
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Alternatives = new AlternativeMonstersInGroupLightInformations[reader.ReadShort()];
			for (var i = 0; i < Alternatives.Length; i++)
			{
				(Alternatives[i] = new AlternativeMonstersInGroupLightInformations()).Deserialize(reader);
			}
		}
	}
}
