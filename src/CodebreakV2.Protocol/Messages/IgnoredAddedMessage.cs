using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class IgnoredAddedMessage
	{
		public IgnoredInformations IgnoreAdded { get; set; }
		public Boolean Session { get; set; }
		public void Serialize(IDataWriter writer)
		{
			IgnoreAdded.Serialize(writer);
			writer.WriteBoolean(Session);
		}
		public void Deserialize(IDataReader reader)
		{
			IgnoreAdded = new IgnoredInformations();
			IgnoreAdded.Deserialize(reader);
			Session = reader.ReadBoolean();
		}
	}
}
