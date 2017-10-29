using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ObjectGroundRemovedMessage
	{
		public UInt16 Cell { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)Cell);
		}
		public void Deserialize(IDataReader reader)
		{
			Cell = (UInt16)reader.ReadVarShort();
		}
	}
}
