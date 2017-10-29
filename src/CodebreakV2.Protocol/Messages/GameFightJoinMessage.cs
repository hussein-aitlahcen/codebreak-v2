using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameFightJoinMessage
	{
		public Boolean IsTeamPhase { get; set; }
		public Boolean CanBeCancelled { get; set; }
		public Boolean CanSayReady { get; set; }
		public Boolean IsFightStarted { get; set; }
		public UInt16 TimeMaxBeforeFightStart { get; set; }
		public Byte FightType { get; set; }
		public void Serialize(IDataWriter writer)
		{
			UInt32 wrappedBoolean = 0;
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, IsTeamPhase);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 1, CanBeCancelled);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 2, CanSayReady);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 3, IsFightStarted);
			writer.WriteByte((Byte)wrappedBoolean);
			writer.WriteShort((Int16)TimeMaxBeforeFightStart);
			writer.WriteByte(FightType);
		}
		public void Deserialize(IDataReader reader)
		{
			UInt32 wrappedBoolean = 0;
			wrappedBoolean = (UInt32)reader.ReadByte();
			IsTeamPhase = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
			CanBeCancelled = BooleanByteWrapper.GetFlag(wrappedBoolean, 1);
			CanSayReady = BooleanByteWrapper.GetFlag(wrappedBoolean, 2);
			IsFightStarted = BooleanByteWrapper.GetFlag(wrappedBoolean, 3);
			TimeMaxBeforeFightStart = (UInt16)reader.ReadShort();
			FightType = reader.ReadByte();
		}
	}
}
