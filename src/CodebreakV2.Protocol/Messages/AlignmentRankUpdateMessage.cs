using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AlignmentRankUpdateMessage
	{
		public Byte AlignmentRank { get; set; }
		public Boolean Verbose { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(AlignmentRank);
			writer.WriteBoolean(Verbose);
		}
		public void Deserialize(IDataReader reader)
		{
			AlignmentRank = reader.ReadByte();
			Verbose = reader.ReadBoolean();
		}
	}
}
