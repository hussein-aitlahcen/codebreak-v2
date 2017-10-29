using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameRolePlayArenaRegisterMessage
	{
		public UInt32 BattleMode { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt((Int32)BattleMode);
		}
		public void Deserialize(IDataReader reader)
		{
			BattleMode = (UInt32)reader.ReadInt();
		}
	}
}
