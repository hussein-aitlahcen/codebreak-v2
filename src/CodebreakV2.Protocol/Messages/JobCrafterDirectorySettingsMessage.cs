using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class JobCrafterDirectorySettingsMessage
	{
		public JobCrafterDirectorySettings[] CraftersSettings { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < CraftersSettings.Length; i++)
			{
				CraftersSettings[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			CraftersSettings = new JobCrafterDirectorySettings[reader.ReadShort()];
			for (var i = 0; i < CraftersSettings.Length; i++)
			{
				(CraftersSettings[i] = new JobCrafterDirectorySettings()).Deserialize(reader);
			}
		}
	}
}
