using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class NotificationListMessage
	{
		public Int32[] Flags { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Flags.Length; i++)
			{
				writer.WriteVarInt(Flags[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Flags = new Int32[reader.ReadShort()];
			for (var i = 0; i < Flags.Length; i++)
			{
				Flags[i] = reader.ReadVarInt();
			}
		}
	}
}
