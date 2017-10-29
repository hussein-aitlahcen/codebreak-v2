using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class NotificationUpdateFlagMessage
	{
		public UInt16 Index { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)Index);
		}
		public void Deserialize(IDataReader reader)
		{
			Index = (UInt16)reader.ReadVarShort();
		}
	}
}
