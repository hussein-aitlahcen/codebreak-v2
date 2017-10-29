using System;
namespace CodebreakV2.Protocol.Types
{
	public class FightResultPlayerListEntry : FightResultFighterListEntry
	{
		public Byte Level { get; set; }
		public FightResultAdditionalData[] Additional { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(Level);
			for (var i = 0; i < Additional.Length; i++)
			{
				Additional[i].Serialize(writer);
			}
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Level = reader.ReadByte();
			Additional = new FightResultAdditionalData[reader.ReadShort()];
			for (var i = 0; i < Additional.Length; i++)
			{
				(Additional[i] = new FightResultAdditionalData()).Deserialize(reader);
			}
		}
	}
}
