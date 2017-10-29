using System;
namespace CodebreakV2.Protocol.Types
{
	public class AbstractContactInformations
	{
		public UInt32 AccountId { get; set; }
		public String AccountName { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt((Int32)AccountId);
			writer.WriteUTF(AccountName);
		}
		public void Deserialize(IDataReader reader)
		{
			AccountId = (UInt32)reader.ReadInt();
			AccountName = reader.ReadUTF();
		}
	}
}
