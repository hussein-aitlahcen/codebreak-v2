using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class MimicryObjectPreviewMessage
	{
		public ObjectItem Result { get; set; }
		public void Serialize(IDataWriter writer)
		{
			Result.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			Result = new ObjectItem();
			Result.Deserialize(reader);
		}
	}
}
