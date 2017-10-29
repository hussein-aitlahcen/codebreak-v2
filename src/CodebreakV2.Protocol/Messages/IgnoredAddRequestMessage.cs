using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class IgnoredAddRequestMessage
	{
		public String Name { get; set; }
		public Boolean Session { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(Name);
			writer.WriteBoolean(Session);
		}
		public void Deserialize(IDataReader reader)
		{
			Name = reader.ReadUTF();
			Session = reader.ReadBoolean();
		}
	}
}
