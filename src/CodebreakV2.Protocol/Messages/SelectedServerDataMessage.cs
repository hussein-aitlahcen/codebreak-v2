using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class SelectedServerDataMessage
	{
		public UInt16 ServerId { get; set; }
		public String Address { get; set; }
		public UInt16 Port { get; set; }
		public Boolean CanCreateNewCharacter { get; set; }
		public SByte[] Ticket { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)ServerId);
			writer.WriteUTF(Address);
			writer.WriteShort((Int16)Port);
			writer.WriteBoolean(CanCreateNewCharacter);
			for (var i = 0; i < Ticket.Length; i++)
			{
				writer.WriteByte((Byte)Ticket[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			ServerId = (UInt16)reader.ReadVarShort();
			Address = reader.ReadUTF();
			Port = (UInt16)reader.ReadShort();
			CanCreateNewCharacter = reader.ReadBoolean();
			Ticket = new SByte[reader.ReadVarInt()];
			for (var i = 0; i < Ticket.Length; i++)
			{
				Ticket[i] = (SByte)reader.ReadByte();
			}
		}
	}
}
