using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class DisplayNumericalValuePaddockMessage
	{
		public Int32 RideId { get; set; }
		public Int32 Value { get; set; }
		public Byte Type { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt(RideId);
			writer.WriteInt(Value);
			writer.WriteByte(Type);
		}
		public void Deserialize(IDataReader reader)
		{
			RideId = reader.ReadInt();
			Value = reader.ReadInt();
			Type = reader.ReadByte();
		}
	}
}
