using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ShowCellSpectatorMessage : ShowCellMessage
	{
		public String PlayerName { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(PlayerName);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			PlayerName = reader.ReadUTF();
		}
	}
}
