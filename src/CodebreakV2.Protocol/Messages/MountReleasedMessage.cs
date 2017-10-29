using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class MountReleasedMessage
	{
		public Int32 MountId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt(MountId);
		}
		public void Deserialize(IDataReader reader)
		{
			MountId = reader.ReadVarInt();
		}
	}
}
