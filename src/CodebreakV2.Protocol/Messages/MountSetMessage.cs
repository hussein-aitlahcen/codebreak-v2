using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class MountSetMessage
	{
		public MountClientData MountData { get; set; }
		public void Serialize(IDataWriter writer)
		{
			MountData.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			MountData = new MountClientData();
			MountData.Deserialize(reader);
		}
	}
}
