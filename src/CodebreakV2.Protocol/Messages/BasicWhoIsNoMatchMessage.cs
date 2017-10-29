using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class BasicWhoIsNoMatchMessage
	{
		public String Search { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(Search);
		}
		public void Deserialize(IDataReader reader)
		{
			Search = reader.ReadUTF();
		}
	}
}
