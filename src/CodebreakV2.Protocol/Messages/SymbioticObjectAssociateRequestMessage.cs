using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class SymbioticObjectAssociateRequestMessage
	{
		public UInt32 SymbioteUID { get; set; }
		public Byte SymbiotePos { get; set; }
		public UInt32 HostUID { get; set; }
		public Byte HostPos { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)SymbioteUID);
			writer.WriteByte(SymbiotePos);
			writer.WriteVarInt((Int32)HostUID);
			writer.WriteByte(HostPos);
		}
		public void Deserialize(IDataReader reader)
		{
			SymbioteUID = (UInt32)reader.ReadVarInt();
			SymbiotePos = reader.ReadByte();
			HostUID = (UInt32)reader.ReadVarInt();
			HostPos = reader.ReadByte();
		}
	}
}
