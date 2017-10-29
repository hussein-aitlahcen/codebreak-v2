using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class HavenBagPermissionsUpdateMessage
	{
		public UInt32 Permissions { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt((Int32)Permissions);
		}
		public void Deserialize(IDataReader reader)
		{
			Permissions = (UInt32)reader.ReadInt();
		}
	}
}
