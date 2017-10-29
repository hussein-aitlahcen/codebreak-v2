using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class JobCrafterDirectoryAddMessage
	{
		public JobCrafterDirectoryListEntry ListEntry { get; set; }
		public void Serialize(IDataWriter writer)
		{
			ListEntry.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			ListEntry = new JobCrafterDirectoryListEntry();
			ListEntry.Deserialize(reader);
		}
	}
}
