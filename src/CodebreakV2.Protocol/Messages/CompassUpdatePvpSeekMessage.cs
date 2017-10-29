using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class CompassUpdatePvpSeekMessage : CompassUpdateMessage
	{
		public Int64 MemberId { get; set; }
		public String MemberName { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(MemberId);
			writer.WriteUTF(MemberName);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			MemberId = reader.ReadVarLong();
			MemberName = reader.ReadUTF();
		}
	}
}
