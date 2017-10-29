using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ServerSettingsMessage
	{
		public String Lang { get; set; }
		public Byte Community { get; set; }
		public SByte GameType { get; set; }
		public UInt16 ArenaLeaveBanTime { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(Lang);
			writer.WriteByte(Community);
			writer.WriteByte((Byte)GameType);
			writer.WriteVarShort((Int16)ArenaLeaveBanTime);
		}
		public void Deserialize(IDataReader reader)
		{
			Lang = reader.ReadUTF();
			Community = reader.ReadByte();
			GameType = (SByte)reader.ReadByte();
			ArenaLeaveBanTime = (UInt16)reader.ReadVarShort();
		}
	}
}
