using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class MapFightCountMessage
	{
		public UInt16 FightCount { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)FightCount);
		}
		public void Deserialize(IDataReader reader)
		{
			FightCount = (UInt16)reader.ReadVarShort();
		}
	}
}
