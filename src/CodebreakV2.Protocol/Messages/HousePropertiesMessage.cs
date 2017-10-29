using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class HousePropertiesMessage
	{
		public UInt32 HouseId { get; set; }
		public UInt32[] DoorsOnMap { get; set; }
		public HouseInstanceInformations Properties { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)HouseId);
			for (var i = 0; i < DoorsOnMap.Length; i++)
			{
				writer.WriteInt((Int32)DoorsOnMap[i]);
			}
			Properties.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			HouseId = (UInt32)reader.ReadVarInt();
			DoorsOnMap = new UInt32[reader.ReadShort()];
			for (var i = 0; i < DoorsOnMap.Length; i++)
			{
				DoorsOnMap[i] = (UInt32)reader.ReadInt();
			}
			Properties = new HouseInstanceInformations();
			Properties.Deserialize(reader);
		}
	}
}
