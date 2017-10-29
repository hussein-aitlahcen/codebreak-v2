using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class IdentificationAccountForceMessage : IdentificationMessage
	{
		public String ForcedAccountLogin { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(ForcedAccountLogin);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ForcedAccountLogin = reader.ReadUTF();
		}
	}
}
