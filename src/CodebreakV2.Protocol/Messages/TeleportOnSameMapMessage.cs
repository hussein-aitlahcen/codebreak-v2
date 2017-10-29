using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class TeleportOnSameMapMessage
	{
		public Double TargetId { get; set; }
		public UInt16 CellId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(TargetId);
			writer.WriteVarShort((Int16)CellId);
		}
		public void Deserialize(IDataReader reader)
		{
			TargetId = reader.ReadDouble();
			CellId = (UInt16)reader.ReadVarShort();
		}
	}
}
