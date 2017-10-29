using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PartyNameSetErrorMessage : AbstractPartyMessage
	{
		public Byte Result { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(Result);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Result = reader.ReadByte();
		}
	}
}
