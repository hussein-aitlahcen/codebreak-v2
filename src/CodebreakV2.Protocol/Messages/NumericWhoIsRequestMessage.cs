using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class NumericWhoIsRequestMessage
	{
		public Int64 PlayerId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(PlayerId);
		}
		public void Deserialize(IDataReader reader)
		{
			PlayerId = reader.ReadVarLong();
		}
	}
}
