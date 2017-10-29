using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AbstractGameActionWithAckMessage : AbstractGameActionMessage
	{
		public Int16 WaitAckId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort(WaitAckId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			WaitAckId = reader.ReadShort();
		}
	}
}
