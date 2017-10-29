using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameFightPlacementSwapPositionsOfferMessage
	{
		public UInt32 RequestId { get; set; }
		public Double RequesterId { get; set; }
		public UInt16 RequesterCellId { get; set; }
		public Double RequestedId { get; set; }
		public UInt16 RequestedCellId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt((Int32)RequestId);
			writer.WriteDouble(RequesterId);
			writer.WriteVarShort((Int16)RequesterCellId);
			writer.WriteDouble(RequestedId);
			writer.WriteVarShort((Int16)RequestedCellId);
		}
		public void Deserialize(IDataReader reader)
		{
			RequestId = (UInt32)reader.ReadInt();
			RequesterId = reader.ReadDouble();
			RequesterCellId = (UInt16)reader.ReadVarShort();
			RequestedId = reader.ReadDouble();
			RequestedCellId = (UInt16)reader.ReadVarShort();
		}
	}
}
