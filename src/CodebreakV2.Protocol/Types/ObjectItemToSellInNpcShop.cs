using System;
namespace CodebreakV2.Protocol.Types
{
	public class ObjectItemToSellInNpcShop : ObjectItemMinimalInformation
	{
		public Int64 ObjectPrice { get; set; }
		public String BuyCriterion { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(ObjectPrice);
			writer.WriteUTF(BuyCriterion);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ObjectPrice = reader.ReadVarLong();
			BuyCriterion = reader.ReadUTF();
		}
	}
}
