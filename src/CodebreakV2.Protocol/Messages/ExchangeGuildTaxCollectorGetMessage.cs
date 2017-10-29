using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeGuildTaxCollectorGetMessage
	{
		public String CollectorName { get; set; }
		public Int16 WorldX { get; set; }
		public Int16 WorldY { get; set; }
		public Double MapId { get; set; }
		public UInt16 SubAreaId { get; set; }
		public String UserName { get; set; }
		public Int64 CallerId { get; set; }
		public String CallerName { get; set; }
		public Double Experience { get; set; }
		public UInt16 Pods { get; set; }
		public ObjectItemGenericQuantity[] ObjectsInfos { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(CollectorName);
			writer.WriteShort(WorldX);
			writer.WriteShort(WorldY);
			writer.WriteDouble(MapId);
			writer.WriteVarShort((Int16)SubAreaId);
			writer.WriteUTF(UserName);
			writer.WriteVarLong(CallerId);
			writer.WriteUTF(CallerName);
			writer.WriteDouble(Experience);
			writer.WriteVarShort((Int16)Pods);
			for (var i = 0; i < ObjectsInfos.Length; i++)
			{
				ObjectsInfos[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			CollectorName = reader.ReadUTF();
			WorldX = reader.ReadShort();
			WorldY = reader.ReadShort();
			MapId = reader.ReadDouble();
			SubAreaId = (UInt16)reader.ReadVarShort();
			UserName = reader.ReadUTF();
			CallerId = reader.ReadVarLong();
			CallerName = reader.ReadUTF();
			Experience = reader.ReadDouble();
			Pods = (UInt16)reader.ReadVarShort();
			ObjectsInfos = new ObjectItemGenericQuantity[reader.ReadShort()];
			for (var i = 0; i < ObjectsInfos.Length; i++)
			{
				(ObjectsInfos[i] = new ObjectItemGenericQuantity()).Deserialize(reader);
			}
		}
	}
}
