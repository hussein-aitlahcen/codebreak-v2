using System;
namespace CodebreakV2.Protocol.Types
{
	public class DareVersatileInformations
	{
		public Double DareId { get; set; }
		public UInt32 CountEntrants { get; set; }
		public UInt32 CountWinners { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(DareId);
			writer.WriteInt((Int32)CountEntrants);
			writer.WriteInt((Int32)CountWinners);
		}
		public void Deserialize(IDataReader reader)
		{
			DareId = reader.ReadDouble();
			CountEntrants = (UInt32)reader.ReadInt();
			CountWinners = (UInt32)reader.ReadInt();
		}
	}
}
