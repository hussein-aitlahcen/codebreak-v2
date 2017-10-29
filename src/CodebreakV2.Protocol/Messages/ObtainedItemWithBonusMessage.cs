using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ObtainedItemWithBonusMessage : ObtainedItemMessage
	{
		public UInt32 BonusQuantity { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((Int32)BonusQuantity);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			BonusQuantity = (UInt32)reader.ReadVarInt();
		}
	}
}
