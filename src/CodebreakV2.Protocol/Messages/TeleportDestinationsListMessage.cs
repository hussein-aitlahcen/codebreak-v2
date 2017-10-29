using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class TeleportDestinationsListMessage
	{
		public Byte TeleporterType { get; set; }
		public Double[] MapIds { get; set; }
		public UInt16[] SubAreaIds { get; set; }
		public UInt16[] Costs { get; set; }
		public Byte[] DestTeleporterType { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(TeleporterType);
			for (var i = 0; i < MapIds.Length; i++)
			{
				writer.WriteDouble(MapIds[i]);
			}
			for (var i = 0; i < SubAreaIds.Length; i++)
			{
				writer.WriteVarShort((Int16)SubAreaIds[i]);
			}
			for (var i = 0; i < Costs.Length; i++)
			{
				writer.WriteVarShort((Int16)Costs[i]);
			}
			for (var i = 0; i < DestTeleporterType.Length; i++)
			{
				writer.WriteByte(DestTeleporterType[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			TeleporterType = reader.ReadByte();
			MapIds = new Double[reader.ReadShort()];
			for (var i = 0; i < MapIds.Length; i++)
			{
				MapIds[i] = reader.ReadDouble();
			}
			SubAreaIds = new UInt16[reader.ReadShort()];
			for (var i = 0; i < SubAreaIds.Length; i++)
			{
				SubAreaIds[i] = (UInt16)reader.ReadVarShort();
			}
			Costs = new UInt16[reader.ReadShort()];
			for (var i = 0; i < Costs.Length; i++)
			{
				Costs[i] = (UInt16)reader.ReadVarShort();
			}
			DestTeleporterType = new Byte[reader.ReadShort()];
			for (var i = 0; i < DestTeleporterType.Length; i++)
			{
				DestTeleporterType[i] = reader.ReadByte();
			}
		}
	}
}
