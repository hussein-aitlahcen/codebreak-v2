using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class BasicAckMessage
	{
		public UInt32 Seq { get; set; }
		public UInt16 LastPacketId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)Seq);
			writer.WriteVarShort((Int16)LastPacketId);
		}
		public void Deserialize(IDataReader reader)
		{
			Seq = (UInt32)reader.ReadVarInt();
			LastPacketId = (UInt16)reader.ReadVarShort();
		}
	}
}
