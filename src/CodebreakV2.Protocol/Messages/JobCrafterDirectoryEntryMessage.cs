using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class JobCrafterDirectoryEntryMessage
	{
		public JobCrafterDirectoryEntryPlayerInfo PlayerInfo { get; set; }
		public JobCrafterDirectoryEntryJobInfo[] JobInfoList { get; set; }
		public EntityLook PlayerLook { get; set; }
		public void Serialize(IDataWriter writer)
		{
			PlayerInfo.Serialize(writer);
			for (var i = 0; i < JobInfoList.Length; i++)
			{
				JobInfoList[i].Serialize(writer);
			}
			PlayerLook.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			PlayerInfo = new JobCrafterDirectoryEntryPlayerInfo();
			PlayerInfo.Deserialize(reader);
			JobInfoList = new JobCrafterDirectoryEntryJobInfo[reader.ReadShort()];
			for (var i = 0; i < JobInfoList.Length; i++)
			{
				(JobInfoList[i] = new JobCrafterDirectoryEntryJobInfo()).Deserialize(reader);
			}
			PlayerLook = new EntityLook();
			PlayerLook.Deserialize(reader);
		}
	}
}
