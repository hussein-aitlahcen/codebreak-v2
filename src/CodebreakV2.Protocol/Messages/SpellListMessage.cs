using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class SpellListMessage
	{
		public Boolean SpellPrevisualization { get; set; }
		public SpellItem[] Spells { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(SpellPrevisualization);
			for (var i = 0; i < Spells.Length; i++)
			{
				Spells[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			SpellPrevisualization = reader.ReadBoolean();
			Spells = new SpellItem[reader.ReadShort()];
			for (var i = 0; i < Spells.Length; i++)
			{
				(Spells[i] = new SpellItem()).Deserialize(reader);
			}
		}
	}
}
