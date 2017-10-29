using System;
namespace CodebreakV2.Protocol.Types
{
	public class TrustCertificate
	{
		public UInt32 Id { get; set; }
		public String Hash { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt((Int32)Id);
			writer.WriteUTF(Hash);
		}
		public void Deserialize(IDataReader reader)
		{
			Id = (UInt32)reader.ReadInt();
			Hash = reader.ReadUTF();
		}
	}
}
