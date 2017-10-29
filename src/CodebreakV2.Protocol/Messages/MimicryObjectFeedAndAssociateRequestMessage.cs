using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class MimicryObjectFeedAndAssociateRequestMessage : SymbioticObjectAssociateRequestMessage
	{
		public UInt32 FoodUID { get; set; }
		public Byte FoodPos { get; set; }
		public Boolean Preview { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((Int32)FoodUID);
			writer.WriteByte(FoodPos);
			writer.WriteBoolean(Preview);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			FoodUID = (UInt32)reader.ReadVarInt();
			FoodPos = reader.ReadByte();
			Preview = reader.ReadBoolean();
		}
	}
}
