using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class NpcGenericActionRequestMessage
	{
		public Int32 NpcId { get; set; }
		public Byte NpcActionId { get; set; }
		public Double NpcMapId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt(NpcId);
			writer.WriteByte(NpcActionId);
			writer.WriteDouble(NpcMapId);
		}
		public void Deserialize(IDataReader reader)
		{
			NpcId = reader.ReadInt();
			NpcActionId = reader.ReadByte();
			NpcMapId = reader.ReadDouble();
		}
	}
}
