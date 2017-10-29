using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class StorageKamasUpdateMessage
	{
		public Int64 KamasTotal { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(KamasTotal);
		}
		public void Deserialize(IDataReader reader)
		{
			KamasTotal = reader.ReadVarLong();
		}
	}
}
