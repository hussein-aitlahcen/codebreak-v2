using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class BasicWhoIsRequestMessage
	{
		public Boolean Verbose { get; set; }
		public String Search { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(Verbose);
			writer.WriteUTF(Search);
		}
		public void Deserialize(IDataReader reader)
		{
			Verbose = reader.ReadBoolean();
			Search = reader.ReadUTF();
		}
	}
}
