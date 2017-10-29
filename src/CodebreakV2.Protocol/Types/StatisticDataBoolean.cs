using System;
namespace CodebreakV2.Protocol.Types
{
	public class StatisticDataBoolean : StatisticData
	{
		public Boolean Value { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteBoolean(Value);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Value = reader.ReadBoolean();
		}
	}
}
