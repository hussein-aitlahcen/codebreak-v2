using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ChatSmileyMessage
	{
		public Double EntityId { get; set; }
		public UInt16 SmileyId { get; set; }
		public UInt32 AccountId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(EntityId);
			writer.WriteVarShort((Int16)SmileyId);
			writer.WriteInt((Int32)AccountId);
		}
		public void Deserialize(IDataReader reader)
		{
			EntityId = reader.ReadDouble();
			SmileyId = (UInt16)reader.ReadVarShort();
			AccountId = (UInt32)reader.ReadInt();
		}
	}
}
