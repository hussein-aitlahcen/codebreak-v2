using System;
namespace CodebreakV2.Protocol.Types
{
	public class DareInformations
	{
		public Double DareId { get; set; }
		public CharacterBasicMinimalInformations Creator { get; set; }
		public Int64 SubscriptionFee { get; set; }
		public Int64 Jackpot { get; set; }
		public UInt16 MaxCountWinners { get; set; }
		public Double EndDate { get; set; }
		public Boolean IsPrivate { get; set; }
		public UInt32 GuildId { get; set; }
		public UInt32 AllianceId { get; set; }
		public DareCriteria[] Criterions { get; set; }
		public Double StartDate { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(DareId);
			Creator.Serialize(writer);
			writer.WriteVarLong(SubscriptionFee);
			writer.WriteVarLong(Jackpot);
			writer.WriteShort((Int16)MaxCountWinners);
			writer.WriteDouble(EndDate);
			writer.WriteBoolean(IsPrivate);
			writer.WriteVarInt((Int32)GuildId);
			writer.WriteVarInt((Int32)AllianceId);
			for (var i = 0; i < Criterions.Length; i++)
			{
				Criterions[i].Serialize(writer);
			}
			writer.WriteDouble(StartDate);
		}
		public void Deserialize(IDataReader reader)
		{
			DareId = reader.ReadDouble();
			Creator = new CharacterBasicMinimalInformations();
			Creator.Deserialize(reader);
			SubscriptionFee = reader.ReadVarLong();
			Jackpot = reader.ReadVarLong();
			MaxCountWinners = (UInt16)reader.ReadShort();
			EndDate = reader.ReadDouble();
			IsPrivate = reader.ReadBoolean();
			GuildId = (UInt32)reader.ReadVarInt();
			AllianceId = (UInt32)reader.ReadVarInt();
			Criterions = new DareCriteria[reader.ReadShort()];
			for (var i = 0; i < Criterions.Length; i++)
			{
				(Criterions[i] = new DareCriteria()).Deserialize(reader);
			}
			StartDate = reader.ReadDouble();
		}
	}
}
