using System;
namespace CodebreakV2.Protocol.Types
{
	public class HouseInformationsForGuild : HouseInformations
	{
		public UInt32 InstanceId { get; set; }
		public Boolean SecondHand { get; set; }
		public String OwnerName { get; set; }
		public Int16 WorldX { get; set; }
		public Int16 WorldY { get; set; }
		public Double MapId { get; set; }
		public UInt16 SubAreaId { get; set; }
		public Int32[] SkillListIds { get; set; }
		public UInt32 GuildshareParams { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt((Int32)InstanceId);
			writer.WriteBoolean(SecondHand);
			writer.WriteUTF(OwnerName);
			writer.WriteShort(WorldX);
			writer.WriteShort(WorldY);
			writer.WriteDouble(MapId);
			writer.WriteVarShort((Int16)SubAreaId);
			for (var i = 0; i < SkillListIds.Length; i++)
			{
				writer.WriteInt(SkillListIds[i]);
			}
			writer.WriteVarInt((Int32)GuildshareParams);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			InstanceId = (UInt32)reader.ReadInt();
			SecondHand = reader.ReadBoolean();
			OwnerName = reader.ReadUTF();
			WorldX = reader.ReadShort();
			WorldY = reader.ReadShort();
			MapId = reader.ReadDouble();
			SubAreaId = (UInt16)reader.ReadVarShort();
			SkillListIds = new Int32[reader.ReadShort()];
			for (var i = 0; i < SkillListIds.Length; i++)
			{
				SkillListIds[i] = reader.ReadInt();
			}
			GuildshareParams = (UInt32)reader.ReadVarInt();
		}
	}
}
