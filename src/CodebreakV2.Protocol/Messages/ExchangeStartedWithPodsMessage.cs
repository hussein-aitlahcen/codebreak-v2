using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeStartedWithPodsMessage : ExchangeStartedMessage
	{
		public Double FirstCharacterId { get; set; }
		public UInt32 FirstCharacterCurrentWeight { get; set; }
		public UInt32 FirstCharacterMaxWeight { get; set; }
		public Double SecondCharacterId { get; set; }
		public UInt32 SecondCharacterCurrentWeight { get; set; }
		public UInt32 SecondCharacterMaxWeight { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(FirstCharacterId);
			writer.WriteVarInt((Int32)FirstCharacterCurrentWeight);
			writer.WriteVarInt((Int32)FirstCharacterMaxWeight);
			writer.WriteDouble(SecondCharacterId);
			writer.WriteVarInt((Int32)SecondCharacterCurrentWeight);
			writer.WriteVarInt((Int32)SecondCharacterMaxWeight);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			FirstCharacterId = reader.ReadDouble();
			FirstCharacterCurrentWeight = (UInt32)reader.ReadVarInt();
			FirstCharacterMaxWeight = (UInt32)reader.ReadVarInt();
			SecondCharacterId = reader.ReadDouble();
			SecondCharacterCurrentWeight = (UInt32)reader.ReadVarInt();
			SecondCharacterMaxWeight = (UInt32)reader.ReadVarInt();
		}
	}
}
