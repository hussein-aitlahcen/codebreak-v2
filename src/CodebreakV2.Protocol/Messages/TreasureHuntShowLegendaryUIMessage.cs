using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class TreasureHuntShowLegendaryUIMessage
	{
		public UInt16[] AvailableLegendaryIds { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < AvailableLegendaryIds.Length; i++)
			{
				writer.WriteVarShort((Int16)AvailableLegendaryIds[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			AvailableLegendaryIds = new UInt16[reader.ReadShort()];
			for (var i = 0; i < AvailableLegendaryIds.Length; i++)
			{
				AvailableLegendaryIds[i] = (UInt16)reader.ReadVarShort();
			}
		}
	}
}
