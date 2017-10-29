using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AggregateStatWithDataMessage : AggregateStatMessage
	{
		public StatisticData[] Datas { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			for (var i = 0; i < Datas.Length; i++)
			{
				Datas[i].Serialize(writer);
			}
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Datas = new StatisticData[reader.ReadShort()];
			for (var i = 0; i < Datas.Length; i++)
			{
				(Datas[i] = new StatisticData()).Deserialize(reader);
			}
		}
	}
}
