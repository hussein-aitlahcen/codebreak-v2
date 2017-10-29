using System;
namespace CodebreakV2.Protocol.Types
{
	public class StatisticDataShort : StatisticData
	{
		public Int16 Value { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort(Value);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Value = reader.ReadShort();
		}
	}
}
