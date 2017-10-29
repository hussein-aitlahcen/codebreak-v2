using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class LockableStateUpdateStorageMessage : LockableStateUpdateAbstractMessage
	{
		public Double MapId { get; set; }
		public UInt32 ElementId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(MapId);
			writer.WriteVarInt((Int32)ElementId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			MapId = reader.ReadDouble();
			ElementId = (UInt32)reader.ReadVarInt();
		}
	}
}
