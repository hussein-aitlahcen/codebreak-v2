using System;
namespace CodebreakV2.Protocol.Types
{
	public class JobCrafterDirectoryListEntry
	{
		public JobCrafterDirectoryEntryPlayerInfo PlayerInfo { get; set; }
		public JobCrafterDirectoryEntryJobInfo JobInfo { get; set; }
		public void Serialize(IDataWriter writer)
		{
			PlayerInfo.Serialize(writer);
			JobInfo.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			PlayerInfo = new JobCrafterDirectoryEntryPlayerInfo();
			PlayerInfo.Deserialize(reader);
			JobInfo = new JobCrafterDirectoryEntryJobInfo();
			JobInfo.Deserialize(reader);
		}
	}
}
