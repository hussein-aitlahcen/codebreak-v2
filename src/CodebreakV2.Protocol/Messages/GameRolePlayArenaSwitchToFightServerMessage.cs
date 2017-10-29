using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameRolePlayArenaSwitchToFightServerMessage
	{
		public String Address { get; set; }
		public UInt16[] Ports { get; set; }
		public SByte[] Ticket { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(Address);
			for (var i = 0; i < Ports.Length; i++)
			{
				writer.WriteShort((Int16)Ports[i]);
			}
			for (var i = 0; i < Ticket.Length; i++)
			{
				writer.WriteByte((Byte)Ticket[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Address = reader.ReadUTF();
			Ports = new UInt16[reader.ReadShort()];
			for (var i = 0; i < Ports.Length; i++)
			{
				Ports[i] = (UInt16)reader.ReadShort();
			}
			Ticket = new SByte[reader.ReadVarInt()];
			for (var i = 0; i < Ticket.Length; i++)
			{
				Ticket[i] = (SByte)reader.ReadByte();
			}
		}
	}
}
