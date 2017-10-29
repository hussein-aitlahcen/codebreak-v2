using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PaddockPropertiesMessage
	{
		public PaddockInstancesInformations Properties { get; set; }
		public void Serialize(IDataWriter writer)
		{
			Properties.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			Properties = new PaddockInstancesInformations();
			Properties.Deserialize(reader);
		}
	}
}
