using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class JobAllowMultiCraftRequestMessage
	{
		public Boolean Enabled { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(Enabled);
		}
		public void Deserialize(IDataReader reader)
		{
			Enabled = reader.ReadBoolean();
		}
	}
}
