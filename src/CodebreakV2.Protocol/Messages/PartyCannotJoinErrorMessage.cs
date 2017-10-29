using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PartyCannotJoinErrorMessage : AbstractPartyMessage
	{
		public Byte Reason { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(Reason);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Reason = reader.ReadByte();
		}
	}
}
