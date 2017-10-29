using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class SymbioticObjectAssociatedMessage
	{
		public UInt32 HostUID { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)HostUID);
		}
		public void Deserialize(IDataReader reader)
		{
			HostUID = (UInt32)reader.ReadVarInt();
		}
	}
}
