using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class EntityTalkMessage
	{
		public Double EntityId { get; set; }
		public UInt16 TextId { get; set; }
		public String[] Parameters { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(EntityId);
			writer.WriteVarShort((Int16)TextId);
			for (var i = 0; i < Parameters.Length; i++)
			{
				writer.WriteUTF(Parameters[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			EntityId = reader.ReadDouble();
			TextId = (UInt16)reader.ReadVarShort();
			Parameters = new String[reader.ReadShort()];
			for (var i = 0; i < Parameters.Length; i++)
			{
				Parameters[i] = reader.ReadUTF();
			}
		}
	}
}
