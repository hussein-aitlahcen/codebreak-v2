using System;
namespace CodebreakV2.Protocol.Types
{
	public class ObjectItemToSellInBid : ObjectItemToSell
	{
		public UInt32 UnsoldDelay { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt((Int32)UnsoldDelay);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			UnsoldDelay = (UInt32)reader.ReadInt();
		}
	}
}
