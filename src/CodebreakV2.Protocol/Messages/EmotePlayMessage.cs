using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class EmotePlayMessage : EmotePlayAbstractMessage
	{
		public Double ActorId { get; set; }
		public UInt32 AccountId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(ActorId);
			writer.WriteInt((Int32)AccountId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ActorId = reader.ReadDouble();
			AccountId = (UInt32)reader.ReadInt();
		}
	}
}
