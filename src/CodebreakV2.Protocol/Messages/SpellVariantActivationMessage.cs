using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class SpellVariantActivationMessage
	{
		public Boolean Result { get; set; }
		public UInt16 ActivatedSpellId { get; set; }
		public UInt16 DeactivatedSpellId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(Result);
			writer.WriteVarShort((Int16)ActivatedSpellId);
			writer.WriteVarShort((Int16)DeactivatedSpellId);
		}
		public void Deserialize(IDataReader reader)
		{
			Result = reader.ReadBoolean();
			ActivatedSpellId = (UInt16)reader.ReadVarShort();
			DeactivatedSpellId = (UInt16)reader.ReadVarShort();
		}
	}
}
