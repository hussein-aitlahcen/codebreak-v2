using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class CompassUpdatePartyMemberMessage : CompassUpdateMessage
	{
		public Int64 MemberId { get; set; }
		public Boolean Active { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(MemberId);
			writer.WriteBoolean(Active);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			MemberId = reader.ReadVarLong();
			Active = reader.ReadBoolean();
		}
	}
}
