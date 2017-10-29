using System;
namespace CodebreakV2.Protocol.Types
{
	public class StatisticDataByte : StatisticData
	{
		public SByte Value { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte((Byte)Value);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Value = (SByte)reader.ReadByte();
		}
	}
}
