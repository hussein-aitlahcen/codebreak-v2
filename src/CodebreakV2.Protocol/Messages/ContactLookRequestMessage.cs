using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ContactLookRequestMessage
	{
		public Byte RequestId { get; set; }
		public Byte ContactType { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(RequestId);
			writer.WriteByte(ContactType);
		}
		public void Deserialize(IDataReader reader)
		{
			RequestId = reader.ReadByte();
			ContactType = reader.ReadByte();
		}
	}
}
