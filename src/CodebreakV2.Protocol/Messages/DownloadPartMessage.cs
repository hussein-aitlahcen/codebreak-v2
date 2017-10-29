using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class DownloadPartMessage
	{
		public String Id { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(Id);
		}
		public void Deserialize(IDataReader reader)
		{
			Id = reader.ReadUTF();
		}
	}
}
