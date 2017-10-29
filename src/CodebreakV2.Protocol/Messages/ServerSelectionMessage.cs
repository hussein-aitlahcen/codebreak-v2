using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ServerSelectionMessage
	{
		public UInt16 ServerId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)ServerId);
		}
		public void Deserialize(IDataReader reader)
		{
			ServerId = (UInt16)reader.ReadVarShort();
		}
	}
}
