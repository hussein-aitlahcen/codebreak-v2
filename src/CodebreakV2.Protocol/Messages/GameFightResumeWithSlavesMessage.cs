using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameFightResumeWithSlavesMessage : GameFightResumeMessage
	{
		public GameFightResumeSlaveInfo[] SlavesInfo { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			for (var i = 0; i < SlavesInfo.Length; i++)
			{
				SlavesInfo[i].Serialize(writer);
			}
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			SlavesInfo = new GameFightResumeSlaveInfo[reader.ReadShort()];
			for (var i = 0; i < SlavesInfo.Length; i++)
			{
				(SlavesInfo[i] = new GameFightResumeSlaveInfo()).Deserialize(reader);
			}
		}
	}
}
