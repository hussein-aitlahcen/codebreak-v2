using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ChallengeFightJoinRefusedMessage
	{
		public Int64 PlayerId { get; set; }
		public SByte Reason { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(PlayerId);
			writer.WriteByte((Byte)Reason);
		}
		public void Deserialize(IDataReader reader)
		{
			PlayerId = reader.ReadVarLong();
			Reason = (SByte)reader.ReadByte();
		}
	}
}
