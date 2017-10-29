using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class DareCreationRequestMessage
	{
		public Int64 SubscriptionFee { get; set; }
		public Int64 Jackpot { get; set; }
		public UInt16 MaxCountWinners { get; set; }
		public UInt32 DelayBeforeStart { get; set; }
		public UInt32 Duration { get; set; }
		public Boolean IsPrivate { get; set; }
		public Boolean IsForGuild { get; set; }
		public Boolean IsForAlliance { get; set; }
		public Boolean NeedNotifications { get; set; }
		public DareCriteria[] Criterions { get; set; }
		public void Serialize(IDataWriter writer)
		{
			UInt32 wrappedBoolean = 0;
			writer.WriteVarLong(SubscriptionFee);
			writer.WriteVarLong(Jackpot);
			writer.WriteShort((Int16)MaxCountWinners);
			writer.WriteUnsignedInt(DelayBeforeStart);
			writer.WriteUnsignedInt(Duration);
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, IsPrivate);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 1, IsForGuild);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 2, IsForAlliance);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 3, NeedNotifications);
			writer.WriteByte((Byte)wrappedBoolean);
			for (var i = 0; i < Criterions.Length; i++)
			{
				Criterions[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			UInt32 wrappedBoolean = 0;
			SubscriptionFee = reader.ReadVarLong();
			Jackpot = reader.ReadVarLong();
			MaxCountWinners = (UInt16)reader.ReadShort();
			DelayBeforeStart = reader.ReadUnsignedInt();
			Duration = reader.ReadUnsignedInt();
			wrappedBoolean = (UInt32)reader.ReadByte();
			IsPrivate = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
			IsForGuild = BooleanByteWrapper.GetFlag(wrappedBoolean, 1);
			IsForAlliance = BooleanByteWrapper.GetFlag(wrappedBoolean, 2);
			NeedNotifications = BooleanByteWrapper.GetFlag(wrappedBoolean, 3);
			Criterions = new DareCriteria[reader.ReadShort()];
			for (var i = 0; i < Criterions.Length; i++)
			{
				(Criterions[i] = new DareCriteria()).Deserialize(reader);
			}
		}
	}
}
