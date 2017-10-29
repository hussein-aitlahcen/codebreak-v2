using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AbstractGameActionMessage
	{
		public UInt16 ActionId { get; set; }
		public Double SourceId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)ActionId);
			writer.WriteDouble(SourceId);
		}
		public void Deserialize(IDataReader reader)
		{
			ActionId = (UInt16)reader.ReadVarShort();
			SourceId = reader.ReadDouble();
		}
	}
}
