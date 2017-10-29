using System;
namespace CodebreakV2.Protocol.Types
{
	public class PartyMemberInformations : CharacterBaseInformations
	{
		public UInt32 LifePoints { get; set; }
		public UInt32 MaxLifePoints { get; set; }
		public UInt16 Prospecting { get; set; }
		public Byte RegenRate { get; set; }
		public UInt16 Initiative { get; set; }
		public SByte AlignmentSide { get; set; }
		public Int16 WorldX { get; set; }
		public Int16 WorldY { get; set; }
		public Double MapId { get; set; }
		public UInt16 SubAreaId { get; set; }
		public PlayerStatus Status { get; set; }
		public PartyCompanionMemberInformations[] Companions { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((Int32)LifePoints);
			writer.WriteVarInt((Int32)MaxLifePoints);
			writer.WriteVarShort((Int16)Prospecting);
			writer.WriteByte(RegenRate);
			writer.WriteVarShort((Int16)Initiative);
			writer.WriteByte((Byte)AlignmentSide);
			writer.WriteShort(WorldX);
			writer.WriteShort(WorldY);
			writer.WriteDouble(MapId);
			writer.WriteVarShort((Int16)SubAreaId);
			Status.Serialize(writer);
			for (var i = 0; i < Companions.Length; i++)
			{
				Companions[i].Serialize(writer);
			}
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			LifePoints = (UInt32)reader.ReadVarInt();
			MaxLifePoints = (UInt32)reader.ReadVarInt();
			Prospecting = (UInt16)reader.ReadVarShort();
			RegenRate = reader.ReadByte();
			Initiative = (UInt16)reader.ReadVarShort();
			AlignmentSide = (SByte)reader.ReadByte();
			WorldX = reader.ReadShort();
			WorldY = reader.ReadShort();
			MapId = reader.ReadDouble();
			SubAreaId = (UInt16)reader.ReadVarShort();
			Status = new PlayerStatus();
			Status.Deserialize(reader);
			Companions = new PartyCompanionMemberInformations[reader.ReadShort()];
			for (var i = 0; i < Companions.Length; i++)
			{
				(Companions[i] = new PartyCompanionMemberInformations()).Deserialize(reader);
			}
		}
	}
}
