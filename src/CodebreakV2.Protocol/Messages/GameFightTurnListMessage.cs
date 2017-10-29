using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameFightTurnListMessage
	{
		public Double[] Ids { get; set; }
		public Double[] DeadsIds { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Ids.Length; i++)
			{
				writer.WriteDouble(Ids[i]);
			}
			for (var i = 0; i < DeadsIds.Length; i++)
			{
				writer.WriteDouble(DeadsIds[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Ids = new Double[reader.ReadShort()];
			for (var i = 0; i < Ids.Length; i++)
			{
				Ids[i] = reader.ReadDouble();
			}
			DeadsIds = new Double[reader.ReadShort()];
			for (var i = 0; i < DeadsIds.Length; i++)
			{
				DeadsIds[i] = reader.ReadDouble();
			}
		}
	}
}
