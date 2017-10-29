using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class BasicWhoAmIRequestMessage
	{
		public Boolean Verbose { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(Verbose);
		}
		public void Deserialize(IDataReader reader)
		{
			Verbose = reader.ReadBoolean();
		}
	}
}
