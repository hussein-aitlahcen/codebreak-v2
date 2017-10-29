using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class LivingObjectMessageMessage
	{
		public UInt16 MsgId { get; set; }
		public UInt32 TimeStamp { get; set; }
		public String Owner { get; set; }
		public UInt16 ObjectGenericId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)MsgId);
			writer.WriteInt((Int32)TimeStamp);
			writer.WriteUTF(Owner);
			writer.WriteVarShort((Int16)ObjectGenericId);
		}
		public void Deserialize(IDataReader reader)
		{
			MsgId = (UInt16)reader.ReadVarShort();
			TimeStamp = (UInt32)reader.ReadInt();
			Owner = reader.ReadUTF();
			ObjectGenericId = (UInt16)reader.ReadVarShort();
		}
	}
}
