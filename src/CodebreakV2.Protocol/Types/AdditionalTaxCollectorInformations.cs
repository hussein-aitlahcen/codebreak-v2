using System;
namespace CodebreakV2.Protocol.Types
{
	public class AdditionalTaxCollectorInformations
	{
		public String CollectorCallerName { get; set; }
		public UInt32 Date { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(CollectorCallerName);
			writer.WriteInt((Int32)Date);
		}
		public void Deserialize(IDataReader reader)
		{
			CollectorCallerName = reader.ReadUTF();
			Date = (UInt32)reader.ReadInt();
		}
	}
}
