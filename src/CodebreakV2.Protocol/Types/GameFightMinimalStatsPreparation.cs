using System;
namespace CodebreakV2.Protocol.Types
{
	public class GameFightMinimalStatsPreparation : GameFightMinimalStats
	{
		public UInt32 Initiative { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((Int32)Initiative);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Initiative = (UInt32)reader.ReadVarInt();
		}
	}
}
