using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class LivingObjectDissociateMessage
	{
		public UInt32 LivingUID { get; set; }
		public Byte LivingPosition { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)LivingUID);
			writer.WriteByte(LivingPosition);
		}
		public void Deserialize(IDataReader reader)
		{
			LivingUID = (UInt32)reader.ReadVarInt();
			LivingPosition = reader.ReadByte();
		}
	}
}
