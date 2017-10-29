using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class JobCrafterDirectoryListMessage
	{
		public JobCrafterDirectoryListEntry[] ListEntries { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < ListEntries.Length; i++)
			{
				ListEntries[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			ListEntries = new JobCrafterDirectoryListEntry[reader.ReadShort()];
			for (var i = 0; i < ListEntries.Length; i++)
			{
				(ListEntries[i] = new JobCrafterDirectoryListEntry()).Deserialize(reader);
			}
		}
	}
}
