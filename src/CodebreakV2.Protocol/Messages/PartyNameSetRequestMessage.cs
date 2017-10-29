using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PartyNameSetRequestMessage : AbstractPartyMessage
	{
		public String PartyName { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(PartyName);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			PartyName = reader.ReadUTF();
		}
	}
}
