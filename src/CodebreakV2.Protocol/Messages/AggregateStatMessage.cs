using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AggregateStatMessage
	{
		public UInt16 StatId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)StatId);
		}
		public void Deserialize(IDataReader reader)
		{
			StatId = (UInt16)reader.ReadVarShort();
		}
	}
}
