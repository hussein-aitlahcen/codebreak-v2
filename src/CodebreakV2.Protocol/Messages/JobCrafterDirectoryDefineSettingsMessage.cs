using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class JobCrafterDirectoryDefineSettingsMessage
	{
		public JobCrafterDirectorySettings Settings { get; set; }
		public void Serialize(IDataWriter writer)
		{
			Settings.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			Settings = new JobCrafterDirectorySettings();
			Settings.Deserialize(reader);
		}
	}
}
