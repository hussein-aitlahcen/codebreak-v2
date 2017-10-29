using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class IdolPartyLostMessage
	{
		public UInt16 IdolId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)IdolId);
		}
		public void Deserialize(IDataReader reader)
		{
			IdolId = (UInt16)reader.ReadVarShort();
		}
	}
}
