using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ClientUIOpenedByObjectMessage : ClientUIOpenedMessage
	{
		public UInt32 Uid { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((Int32)Uid);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Uid = (UInt32)reader.ReadVarInt();
		}
	}
}
