using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class SlaveSwitchContextMessage
	{
		public Double MasterId { get; set; }
		public Double SlaveId { get; set; }
		public SpellItem[] SlaveSpells { get; set; }
		public CharacterCharacteristicsInformations SlaveStats { get; set; }
		public Shortcut[] Shortcuts { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(MasterId);
			writer.WriteDouble(SlaveId);
			for (var i = 0; i < SlaveSpells.Length; i++)
			{
				SlaveSpells[i].Serialize(writer);
			}
			SlaveStats.Serialize(writer);
			for (var i = 0; i < Shortcuts.Length; i++)
			{
				Shortcuts[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			MasterId = reader.ReadDouble();
			SlaveId = reader.ReadDouble();
			SlaveSpells = new SpellItem[reader.ReadShort()];
			for (var i = 0; i < SlaveSpells.Length; i++)
			{
				(SlaveSpells[i] = new SpellItem()).Deserialize(reader);
			}
			SlaveStats = new CharacterCharacteristicsInformations();
			SlaveStats.Deserialize(reader);
			Shortcuts = new Shortcut[reader.ReadShort()];
			for (var i = 0; i < Shortcuts.Length; i++)
			{
				(Shortcuts[i] = new Shortcut()).Deserialize(reader);
			}
		}
	}
}
