using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class IdolPartyRegisterRequestMessage
	{
		public Boolean Register { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(Register);
		}
		public void Deserialize(IDataReader reader)
		{
			Register = reader.ReadBoolean();
		}
	}
}
