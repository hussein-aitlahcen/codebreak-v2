using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class TitleGainedMessage
	{
		public UInt16 TitleId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)TitleId);
		}
		public void Deserialize(IDataReader reader)
		{
			TitleId = (UInt16)reader.ReadVarShort();
		}
	}
}
