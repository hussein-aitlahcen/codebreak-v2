using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class OrnamentGainedMessage
	{
		public UInt16 OrnamentId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteShort((Int16)OrnamentId);
		}
		public void Deserialize(IDataReader reader)
		{
			OrnamentId = (UInt16)reader.ReadShort();
		}
	}
}
