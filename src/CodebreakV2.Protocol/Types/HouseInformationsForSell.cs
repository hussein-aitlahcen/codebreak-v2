using System;
namespace CodebreakV2.Protocol.Types
{
	public class HouseInformationsForSell
	{
		public UInt32 InstanceId { get; set; }
		public Boolean SecondHand { get; set; }
		public UInt32 ModelId { get; set; }
		public String OwnerName { get; set; }
		public Boolean OwnerConnected { get; set; }
		public Int16 WorldX { get; set; }
		public Int16 WorldY { get; set; }
		public UInt16 SubAreaId { get; set; }
		public SByte NbRoom { get; set; }
		public SByte NbChest { get; set; }
		public Int32[] SkillListIds { get; set; }
		public Boolean IsLocked { get; set; }
		public Int64 Price { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt((Int32)InstanceId);
			writer.WriteBoolean(SecondHand);
			writer.WriteVarInt((Int32)ModelId);
			writer.WriteUTF(OwnerName);
			writer.WriteBoolean(OwnerConnected);
			writer.WriteShort(WorldX);
			writer.WriteShort(WorldY);
			writer.WriteVarShort((Int16)SubAreaId);
			writer.WriteByte((Byte)NbRoom);
			writer.WriteByte((Byte)NbChest);
			for (var i = 0; i < SkillListIds.Length; i++)
			{
				writer.WriteInt(SkillListIds[i]);
			}
			writer.WriteBoolean(IsLocked);
			writer.WriteVarLong(Price);
		}
		public void Deserialize(IDataReader reader)
		{
			InstanceId = (UInt32)reader.ReadInt();
			SecondHand = reader.ReadBoolean();
			ModelId = (UInt32)reader.ReadVarInt();
			OwnerName = reader.ReadUTF();
			OwnerConnected = reader.ReadBoolean();
			WorldX = reader.ReadShort();
			WorldY = reader.ReadShort();
			SubAreaId = (UInt16)reader.ReadVarShort();
			NbRoom = (SByte)reader.ReadByte();
			NbChest = (SByte)reader.ReadByte();
			SkillListIds = new Int32[reader.ReadShort()];
			for (var i = 0; i < SkillListIds.Length; i++)
			{
				SkillListIds[i] = reader.ReadInt();
			}
			IsLocked = reader.ReadBoolean();
			Price = reader.ReadVarLong();
		}
	}
}
