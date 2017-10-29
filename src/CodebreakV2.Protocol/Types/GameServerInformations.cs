using System;
namespace CodebreakV2.Protocol.Types
{
	public class GameServerInformations
	{
		public UInt16 Id { get; set; }
		public SByte Type { get; set; }
		public Byte Status { get; set; }
		public Byte Completion { get; set; }
		public Boolean IsSelectable { get; set; }
		public Byte CharactersCount { get; set; }
		public Byte CharactersSlots { get; set; }
		public Double Date { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)Id);
			writer.WriteByte((Byte)Type);
			writer.WriteByte(Status);
			writer.WriteByte(Completion);
			writer.WriteBoolean(IsSelectable);
			writer.WriteByte(CharactersCount);
			writer.WriteByte(CharactersSlots);
			writer.WriteDouble(Date);
		}
		public void Deserialize(IDataReader reader)
		{
			Id = (UInt16)reader.ReadVarShort();
			Type = (SByte)reader.ReadByte();
			Status = reader.ReadByte();
			Completion = reader.ReadByte();
			IsSelectable = reader.ReadBoolean();
			CharactersCount = reader.ReadByte();
			CharactersSlots = reader.ReadByte();
			Date = reader.ReadDouble();
		}
	}
}
