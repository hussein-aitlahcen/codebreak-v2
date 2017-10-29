using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AreaFightModificatorUpdateMessage
	{
		public Int32 SpellPairId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt(SpellPairId);
		}
		public void Deserialize(IDataReader reader)
		{
			SpellPairId = reader.ReadInt();
		}
	}
}
