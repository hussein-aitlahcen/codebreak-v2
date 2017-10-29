using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PartyAbdicateThroneMessage : AbstractPartyMessage
	{
		public Int64 PlayerId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(PlayerId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			PlayerId = reader.ReadVarLong();
		}
	}
}
