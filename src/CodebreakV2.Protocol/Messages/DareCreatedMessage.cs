using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class DareCreatedMessage
	{
		public DareInformations DareInfos { get; set; }
		public Boolean NeedNotifications { get; set; }
		public void Serialize(IDataWriter writer)
		{
			DareInfos.Serialize(writer);
			writer.WriteBoolean(NeedNotifications);
		}
		public void Deserialize(IDataReader reader)
		{
			DareInfos = new DareInformations();
			DareInfos.Deserialize(reader);
			NeedNotifications = reader.ReadBoolean();
		}
	}
}
