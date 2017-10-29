using System;
namespace CodebreakV2.Protocol.Types
{
	public class GoldItem : Item
	{
		public Int64 Sum { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(Sum);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Sum = reader.ReadVarLong();
		}
	}
}
