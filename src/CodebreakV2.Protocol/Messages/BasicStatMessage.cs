using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class BasicStatMessage
	{
		public Double TimeSpent { get; set; }
		public UInt16 StatId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(TimeSpent);
			writer.WriteVarShort((Int16)StatId);
		}
		public void Deserialize(IDataReader reader)
		{
			TimeSpent = reader.ReadDouble();
			StatId = (UInt16)reader.ReadVarShort();
		}
	}
}
