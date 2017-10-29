using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PortalUseRequestMessage
	{
		public UInt32 PortalId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)PortalId);
		}
		public void Deserialize(IDataReader reader)
		{
			PortalId = (UInt32)reader.ReadVarInt();
		}
	}
}
