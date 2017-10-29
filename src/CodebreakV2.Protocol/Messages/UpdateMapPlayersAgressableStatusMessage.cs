using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class UpdateMapPlayersAgressableStatusMessage
	{
		public Int64[] PlayerIds { get; set; }
		public Byte[] Enable { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < PlayerIds.Length; i++)
			{
				writer.WriteVarLong(PlayerIds[i]);
			}
			for (var i = 0; i < Enable.Length; i++)
			{
				writer.WriteByte(Enable[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			PlayerIds = new Int64[reader.ReadShort()];
			for (var i = 0; i < PlayerIds.Length; i++)
			{
				PlayerIds[i] = reader.ReadVarLong();
			}
			Enable = new Byte[reader.ReadShort()];
			for (var i = 0; i < Enable.Length; i++)
			{
				Enable[i] = reader.ReadByte();
			}
		}
	}
}
