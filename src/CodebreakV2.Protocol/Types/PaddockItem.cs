using System;
namespace CodebreakV2.Protocol.Types
{
	public class PaddockItem : ObjectItemInRolePlay
	{
		public ItemDurability Durability { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			Durability.Serialize(writer);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Durability = new ItemDurability();
			Durability.Deserialize(reader);
		}
	}
}
