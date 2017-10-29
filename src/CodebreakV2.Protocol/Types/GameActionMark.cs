using System;
namespace CodebreakV2.Protocol.Types
{
	public class GameActionMark
	{
		public Double MarkAuthorId { get; set; }
		public Byte MarkTeamId { get; set; }
		public UInt32 MarkSpellId { get; set; }
		public Int16 MarkSpellLevel { get; set; }
		public Int16 MarkId { get; set; }
		public SByte MarkType { get; set; }
		public Int16 MarkimpactCell { get; set; }
		public GameActionMarkedCell[] Cells { get; set; }
		public Boolean Active { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(MarkAuthorId);
			writer.WriteByte(MarkTeamId);
			writer.WriteInt((Int32)MarkSpellId);
			writer.WriteShort(MarkSpellLevel);
			writer.WriteShort(MarkId);
			writer.WriteByte((Byte)MarkType);
			writer.WriteShort(MarkimpactCell);
			for (var i = 0; i < Cells.Length; i++)
			{
				Cells[i].Serialize(writer);
			}
			writer.WriteBoolean(Active);
		}
		public void Deserialize(IDataReader reader)
		{
			MarkAuthorId = reader.ReadDouble();
			MarkTeamId = reader.ReadByte();
			MarkSpellId = (UInt32)reader.ReadInt();
			MarkSpellLevel = reader.ReadShort();
			MarkId = reader.ReadShort();
			MarkType = (SByte)reader.ReadByte();
			MarkimpactCell = reader.ReadShort();
			Cells = new GameActionMarkedCell[reader.ReadShort()];
			for (var i = 0; i < Cells.Length; i++)
			{
				(Cells[i] = new GameActionMarkedCell()).Deserialize(reader);
			}
			Active = reader.ReadBoolean();
		}
	}
}
