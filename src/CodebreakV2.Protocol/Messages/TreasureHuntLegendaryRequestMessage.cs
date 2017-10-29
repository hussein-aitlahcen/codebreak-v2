using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class TreasureHuntLegendaryRequestMessage
	{
		public UInt16 LegendaryId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)LegendaryId);
		}
		public void Deserialize(IDataReader reader)
		{
			LegendaryId = (UInt16)reader.ReadVarShort();
		}
	}
}
