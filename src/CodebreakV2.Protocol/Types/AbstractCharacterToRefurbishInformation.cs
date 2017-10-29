using System;
namespace CodebreakV2.Protocol.Types
{
	public class AbstractCharacterToRefurbishInformation : AbstractCharacterInformation
	{
		public Int32[] Colors { get; set; }
		public UInt32 CosmeticId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			for (var i = 0; i < Colors.Length; i++)
			{
				writer.WriteInt(Colors[i]);
			}
			writer.WriteVarInt((Int32)CosmeticId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Colors = new Int32[reader.ReadShort()];
			for (var i = 0; i < Colors.Length; i++)
			{
				Colors[i] = reader.ReadInt();
			}
			CosmeticId = (UInt32)reader.ReadVarInt();
		}
	}
}
