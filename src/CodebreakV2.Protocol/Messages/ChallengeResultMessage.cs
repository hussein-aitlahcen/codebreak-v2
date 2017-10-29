using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ChallengeResultMessage
	{
		public UInt16 ChallengeId { get; set; }
		public Boolean Success { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)ChallengeId);
			writer.WriteBoolean(Success);
		}
		public void Deserialize(IDataReader reader)
		{
			ChallengeId = (UInt16)reader.ReadVarShort();
			Success = reader.ReadBoolean();
		}
	}
}
