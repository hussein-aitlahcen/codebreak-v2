using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class IdentificationSuccessWithLoginTokenMessage : IdentificationSuccessMessage
	{
		public String LoginToken { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(LoginToken);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			LoginToken = reader.ReadUTF();
		}
	}
}
