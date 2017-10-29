using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class EmotePlayMassiveMessage : EmotePlayAbstractMessage
	{
		public Double[] ActorIds { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			for (var i = 0; i < ActorIds.Length; i++)
			{
				writer.WriteDouble(ActorIds[i]);
			}
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ActorIds = new Double[reader.ReadShort()];
			for (var i = 0; i < ActorIds.Length; i++)
			{
				ActorIds[i] = reader.ReadDouble();
			}
		}
	}
}
