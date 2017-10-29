using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameFightSpectateMessage
	{
		public FightDispellableEffectExtendedInformations[] Effects { get; set; }
		public GameActionMark[] Marks { get; set; }
		public UInt16 GameTurn { get; set; }
		public UInt32 FightStart { get; set; }
		public Idol[] Idols { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Effects.Length; i++)
			{
				Effects[i].Serialize(writer);
			}
			for (var i = 0; i < Marks.Length; i++)
			{
				Marks[i].Serialize(writer);
			}
			writer.WriteVarShort((Int16)GameTurn);
			writer.WriteInt((Int32)FightStart);
			for (var i = 0; i < Idols.Length; i++)
			{
				Idols[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Effects = new FightDispellableEffectExtendedInformations[reader.ReadShort()];
			for (var i = 0; i < Effects.Length; i++)
			{
				(Effects[i] = new FightDispellableEffectExtendedInformations()).Deserialize(reader);
			}
			Marks = new GameActionMark[reader.ReadShort()];
			for (var i = 0; i < Marks.Length; i++)
			{
				(Marks[i] = new GameActionMark()).Deserialize(reader);
			}
			GameTurn = (UInt16)reader.ReadVarShort();
			FightStart = (UInt32)reader.ReadInt();
			Idols = new Idol[reader.ReadShort()];
			for (var i = 0; i < Idols.Length; i++)
			{
				(Idols[i] = new Idol()).Deserialize(reader);
			}
		}
	}
}
