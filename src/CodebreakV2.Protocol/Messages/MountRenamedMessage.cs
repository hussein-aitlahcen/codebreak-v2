using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class MountRenamedMessage
	{
		public Int32 MountId { get; set; }
		public String Name { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt(MountId);
			writer.WriteUTF(Name);
		}
		public void Deserialize(IDataReader reader)
		{
			MountId = reader.ReadVarInt();
			Name = reader.ReadUTF();
		}
	}
}
