using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameActionFightTackledMessage : AbstractGameActionMessage
	{
		public Double[] TacklersIds { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			for (var i = 0; i < TacklersIds.Length; i++)
			{
				writer.WriteDouble(TacklersIds[i]);
			}
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			TacklersIds = new Double[reader.ReadShort()];
			for (var i = 0; i < TacklersIds.Length; i++)
			{
				TacklersIds[i] = reader.ReadDouble();
			}
		}
	}
}
