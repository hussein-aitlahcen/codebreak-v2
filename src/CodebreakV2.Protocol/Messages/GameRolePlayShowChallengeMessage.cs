using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameRolePlayShowChallengeMessage
	{
		public FightCommonInformations CommonsInfos { get; set; }
		public void Serialize(IDataWriter writer)
		{
			CommonsInfos.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			CommonsInfos = new FightCommonInformations();
			CommonsInfos.Deserialize(reader);
		}
	}
}
