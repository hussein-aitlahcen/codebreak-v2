using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GuildSpellUpgradeRequestMessage
	{
		public UInt32 SpellId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt((Int32)SpellId);
		}
		public void Deserialize(IDataReader reader)
		{
			SpellId = (UInt32)reader.ReadInt();
		}
	}
}
