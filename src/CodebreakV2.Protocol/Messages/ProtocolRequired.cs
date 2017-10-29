using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ProtocolRequired
	{
		public UInt32 RequiredVersion { get; set; }
		public UInt32 CurrentVersion { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt((Int32)RequiredVersion);
			writer.WriteInt((Int32)CurrentVersion);
		}
		public void Deserialize(IDataReader reader)
		{
			RequiredVersion = (UInt32)reader.ReadInt();
			CurrentVersion = (UInt32)reader.ReadInt();
		}
	}
}
