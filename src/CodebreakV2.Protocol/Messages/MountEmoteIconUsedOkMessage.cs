using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class MountEmoteIconUsedOkMessage
	{
		public Int32 MountId { get; set; }
		public Byte ReactionType { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt(MountId);
			writer.WriteByte(ReactionType);
		}
		public void Deserialize(IDataReader reader)
		{
			MountId = reader.ReadVarInt();
			ReactionType = reader.ReadByte();
		}
	}
}
