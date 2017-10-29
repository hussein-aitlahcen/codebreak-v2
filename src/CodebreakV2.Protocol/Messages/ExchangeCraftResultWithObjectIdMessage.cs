using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeCraftResultWithObjectIdMessage : ExchangeCraftResultMessage
	{
		public UInt16 ObjectGenericId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((Int16)ObjectGenericId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ObjectGenericId = (UInt16)reader.ReadVarShort();
		}
	}
}
