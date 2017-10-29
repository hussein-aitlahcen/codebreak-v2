using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class SpellVariantActivationRequestMessage
	{
		public UInt16 SpellId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)SpellId);
		}
		public void Deserialize(IDataReader reader)
		{
			SpellId = (UInt16)reader.ReadVarShort();
		}
	}
}
