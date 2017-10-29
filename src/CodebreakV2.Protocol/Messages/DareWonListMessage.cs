using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class DareWonListMessage
	{
		public Double[] DareId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < DareId.Length; i++)
			{
				writer.WriteDouble(DareId[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			DareId = new Double[reader.ReadShort()];
			for (var i = 0; i < DareId.Length; i++)
			{
				DareId[i] = reader.ReadDouble();
			}
		}
	}
}
