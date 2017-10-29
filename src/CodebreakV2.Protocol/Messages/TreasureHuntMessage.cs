using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class TreasureHuntMessage
	{
		public Byte QuestType { get; set; }
		public Double StartMapId { get; set; }
		public TreasureHuntStep[] KnownStepsList { get; set; }
		public Byte TotalStepCount { get; set; }
		public UInt32 CheckPointCurrent { get; set; }
		public UInt32 CheckPointTotal { get; set; }
		public Int32 AvailableRetryCount { get; set; }
		public TreasureHuntFlag[] Flags { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(QuestType);
			writer.WriteDouble(StartMapId);
			for (var i = 0; i < KnownStepsList.Length; i++)
			{
				KnownStepsList[i].Serialize(writer);
			}
			writer.WriteByte(TotalStepCount);
			writer.WriteVarInt((Int32)CheckPointCurrent);
			writer.WriteVarInt((Int32)CheckPointTotal);
			writer.WriteInt(AvailableRetryCount);
			for (var i = 0; i < Flags.Length; i++)
			{
				Flags[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			QuestType = reader.ReadByte();
			StartMapId = reader.ReadDouble();
			KnownStepsList = new TreasureHuntStep[reader.ReadShort()];
			for (var i = 0; i < KnownStepsList.Length; i++)
			{
				(KnownStepsList[i] = new TreasureHuntStep()).Deserialize(reader);
			}
			TotalStepCount = reader.ReadByte();
			CheckPointCurrent = (UInt32)reader.ReadVarInt();
			CheckPointTotal = (UInt32)reader.ReadVarInt();
			AvailableRetryCount = reader.ReadInt();
			Flags = new TreasureHuntFlag[reader.ReadShort()];
			for (var i = 0; i < Flags.Length; i++)
			{
				(Flags[i] = new TreasureHuntFlag()).Deserialize(reader);
			}
		}
	}
}
