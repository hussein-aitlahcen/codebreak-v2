using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class InventoryPresetSaveCustomMessage : AbstractPresetSaveMessage
	{
		public Byte[] ItemsPositions { get; set; }
		public UInt32[] ItemsUids { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			for (var i = 0; i < ItemsPositions.Length; i++)
			{
				writer.WriteByte(ItemsPositions[i]);
			}
			for (var i = 0; i < ItemsUids.Length; i++)
			{
				writer.WriteVarInt((Int32)ItemsUids[i]);
			}
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ItemsPositions = new Byte[reader.ReadShort()];
			for (var i = 0; i < ItemsPositions.Length; i++)
			{
				ItemsPositions[i] = reader.ReadByte();
			}
			ItemsUids = new UInt32[reader.ReadShort()];
			for (var i = 0; i < ItemsUids.Length; i++)
			{
				ItemsUids[i] = (UInt32)reader.ReadVarInt();
			}
		}
	}
}
