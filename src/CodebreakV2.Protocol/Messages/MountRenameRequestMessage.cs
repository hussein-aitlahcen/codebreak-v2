using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class MountRenameRequestMessage
	{
		public String Name { get; set; }
		public Int32 MountId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(Name);
			writer.WriteVarInt(MountId);
		}
		public void Deserialize(IDataReader reader)
		{
			Name = reader.ReadUTF();
			MountId = reader.ReadVarInt();
		}
	}
}
