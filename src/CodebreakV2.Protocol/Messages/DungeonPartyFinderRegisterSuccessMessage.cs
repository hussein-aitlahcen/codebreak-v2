using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class DungeonPartyFinderRegisterSuccessMessage
	{
		public UInt16[] DungeonIds { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < DungeonIds.Length; i++)
			{
				writer.WriteVarShort((Int16)DungeonIds[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			DungeonIds = new UInt16[reader.ReadShort()];
			for (var i = 0; i < DungeonIds.Length; i++)
			{
				DungeonIds[i] = (UInt16)reader.ReadVarShort();
			}
		}
	}
}
