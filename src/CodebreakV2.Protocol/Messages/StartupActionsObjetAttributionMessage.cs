using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class StartupActionsObjetAttributionMessage
	{
		public UInt32 ActionId { get; set; }
		public Int64 CharacterId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt((Int32)ActionId);
			writer.WriteVarLong(CharacterId);
		}
		public void Deserialize(IDataReader reader)
		{
			ActionId = (UInt32)reader.ReadInt();
			CharacterId = reader.ReadVarLong();
		}
	}
}
