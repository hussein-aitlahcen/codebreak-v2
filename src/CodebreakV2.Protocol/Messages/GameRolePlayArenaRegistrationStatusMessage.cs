using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameRolePlayArenaRegistrationStatusMessage
	{
		public Boolean Registered { get; set; }
		public Byte Step { get; set; }
		public UInt32 BattleMode { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(Registered);
			writer.WriteByte(Step);
			writer.WriteInt((Int32)BattleMode);
		}
		public void Deserialize(IDataReader reader)
		{
			Registered = reader.ReadBoolean();
			Step = reader.ReadByte();
			BattleMode = (UInt32)reader.ReadInt();
		}
	}
}
