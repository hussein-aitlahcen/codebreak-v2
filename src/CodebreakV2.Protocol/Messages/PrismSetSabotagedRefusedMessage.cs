using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PrismSetSabotagedRefusedMessage
	{
		public UInt16 SubAreaId { get; set; }
		public SByte Reason { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)SubAreaId);
			writer.WriteByte((Byte)Reason);
		}
		public void Deserialize(IDataReader reader)
		{
			SubAreaId = (UInt16)reader.ReadVarShort();
			Reason = (SByte)reader.ReadByte();
		}
	}
}
