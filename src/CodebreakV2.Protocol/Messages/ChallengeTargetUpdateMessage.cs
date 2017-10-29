using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ChallengeTargetUpdateMessage
	{
		public UInt16 ChallengeId { get; set; }
		public Double TargetId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)ChallengeId);
			writer.WriteDouble(TargetId);
		}
		public void Deserialize(IDataReader reader)
		{
			ChallengeId = (UInt16)reader.ReadVarShort();
			TargetId = reader.ReadDouble();
		}
	}
}
