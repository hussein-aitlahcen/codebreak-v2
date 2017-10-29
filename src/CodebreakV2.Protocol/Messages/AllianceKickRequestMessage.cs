using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AllianceKickRequestMessage
	{
		public UInt32 KickedId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)KickedId);
		}
		public void Deserialize(IDataReader reader)
		{
			KickedId = (UInt32)reader.ReadVarInt();
		}
	}
}
