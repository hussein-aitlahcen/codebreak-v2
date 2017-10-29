using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class NewMailMessage : MailStatusMessage
	{
		public UInt32[] SendersAccountId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			for (var i = 0; i < SendersAccountId.Length; i++)
			{
				writer.WriteInt((Int32)SendersAccountId[i]);
			}
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			SendersAccountId = new UInt32[reader.ReadShort()];
			for (var i = 0; i < SendersAccountId.Length; i++)
			{
				SendersAccountId[i] = (UInt32)reader.ReadInt();
			}
		}
	}
}
