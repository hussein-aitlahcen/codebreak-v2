using System;
namespace CodebreakV2.Protocol.Types
{
	public class ActorRestrictionsInformations
	{
		public Boolean CantBeAggressed { get; set; }
		public Boolean CantBeChallenged { get; set; }
		public Boolean CantTrade { get; set; }
		public Boolean CantBeAttackedByMutant { get; set; }
		public Boolean CantRun { get; set; }
		public Boolean ForceSlowWalk { get; set; }
		public Boolean CantMinimize { get; set; }
		public Boolean CantMove { get; set; }
		public Boolean CantAggress { get; set; }
		public Boolean CantChallenge { get; set; }
		public Boolean CantExchange { get; set; }
		public Boolean CantAttack { get; set; }
		public Boolean CantChat { get; set; }
		public Boolean CantBeMerchant { get; set; }
		public Boolean CantUseObject { get; set; }
		public Boolean CantUseTaxCollector { get; set; }
		public Boolean CantUseInteractive { get; set; }
		public Boolean CantSpeakToNPC { get; set; }
		public Boolean CantChangeZone { get; set; }
		public Boolean CantAttackMonster { get; set; }
		public Boolean CantWalk8Directions { get; set; }
		public void Serialize(IDataWriter writer)
		{
			UInt32 wrappedBoolean = 0;
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, CantBeAggressed);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 1, CantBeChallenged);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 2, CantTrade);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 3, CantBeAttackedByMutant);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 4, CantRun);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 5, ForceSlowWalk);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 6, CantMinimize);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 7, CantMove);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 8, CantAggress);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 9, CantChallenge);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 10, CantExchange);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 11, CantAttack);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 12, CantChat);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 13, CantBeMerchant);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 14, CantUseObject);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 15, CantUseTaxCollector);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 16, CantUseInteractive);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 17, CantSpeakToNPC);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 18, CantChangeZone);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 19, CantAttackMonster);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 20, CantWalk8Directions);
			writer.WriteByte((Byte)wrappedBoolean);
		}
		public void Deserialize(IDataReader reader)
		{
			UInt32 wrappedBoolean = 0;
			wrappedBoolean = (UInt32)reader.ReadByte();
			CantBeAggressed = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
			CantBeChallenged = BooleanByteWrapper.GetFlag(wrappedBoolean, 1);
			CantTrade = BooleanByteWrapper.GetFlag(wrappedBoolean, 2);
			CantBeAttackedByMutant = BooleanByteWrapper.GetFlag(wrappedBoolean, 3);
			CantRun = BooleanByteWrapper.GetFlag(wrappedBoolean, 4);
			ForceSlowWalk = BooleanByteWrapper.GetFlag(wrappedBoolean, 5);
			CantMinimize = BooleanByteWrapper.GetFlag(wrappedBoolean, 6);
			CantMove = BooleanByteWrapper.GetFlag(wrappedBoolean, 7);
			CantAggress = BooleanByteWrapper.GetFlag(wrappedBoolean, 8);
			CantChallenge = BooleanByteWrapper.GetFlag(wrappedBoolean, 9);
			CantExchange = BooleanByteWrapper.GetFlag(wrappedBoolean, 10);
			CantAttack = BooleanByteWrapper.GetFlag(wrappedBoolean, 11);
			CantChat = BooleanByteWrapper.GetFlag(wrappedBoolean, 12);
			CantBeMerchant = BooleanByteWrapper.GetFlag(wrappedBoolean, 13);
			CantUseObject = BooleanByteWrapper.GetFlag(wrappedBoolean, 14);
			CantUseTaxCollector = BooleanByteWrapper.GetFlag(wrappedBoolean, 15);
			CantUseInteractive = BooleanByteWrapper.GetFlag(wrappedBoolean, 16);
			CantSpeakToNPC = BooleanByteWrapper.GetFlag(wrappedBoolean, 17);
			CantChangeZone = BooleanByteWrapper.GetFlag(wrappedBoolean, 18);
			CantAttackMonster = BooleanByteWrapper.GetFlag(wrappedBoolean, 19);
			CantWalk8Directions = BooleanByteWrapper.GetFlag(wrappedBoolean, 20);
		}
	}
}
