using System;
namespace CodebreakV2.Protocol.Types
{
	public class ObjectItemInformationWithQuantity : ObjectItemMinimalInformation
	{
		public UInt32 Quantity { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((Int32)Quantity);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Quantity = (UInt32)reader.ReadVarInt();
		}
	}
}
