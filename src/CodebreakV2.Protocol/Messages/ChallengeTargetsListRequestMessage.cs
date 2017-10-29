using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ChallengeTargetsListRequestMessage
	{
		public UInt16 ChallengeId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)ChallengeId);
		}
		public void Deserialize(IDataReader reader)
		{
			ChallengeId = (UInt16)reader.ReadVarShort();
		}
	}
}
