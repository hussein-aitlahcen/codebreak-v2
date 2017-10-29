using System;
namespace CodebreakV2.Protocol.Types
{
	public class PartyCompanionMemberInformations : PartyCompanionBaseInformations
	{
		public UInt16 Initiative { get; set; }
		public UInt32 LifePoints { get; set; }
		public UInt32 MaxLifePoints { get; set; }
		public UInt16 Prospecting { get; set; }
		public Byte RegenRate { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((Int16)Initiative);
			writer.WriteVarInt((Int32)LifePoints);
			writer.WriteVarInt((Int32)MaxLifePoints);
			writer.WriteVarShort((Int16)Prospecting);
			writer.WriteByte(RegenRate);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Initiative = (UInt16)reader.ReadVarShort();
			LifePoints = (UInt32)reader.ReadVarInt();
			MaxLifePoints = (UInt32)reader.ReadVarInt();
			Prospecting = (UInt16)reader.ReadVarShort();
			RegenRate = reader.ReadByte();
		}
	}
}
