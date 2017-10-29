using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class MapRunningFightDetailsRequestMessage
	{
		public UInt32 FightId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt((Int32)FightId);
		}
		public void Deserialize(IDataReader reader)
		{
			FightId = (UInt32)reader.ReadInt();
		}
	}
}
