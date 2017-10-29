using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GuildInformationsGeneralMessage
	{
		public Boolean AbandonnedPaddock { get; set; }
		public Byte Level { get; set; }
		public Int64 ExpLevelFloor { get; set; }
		public Int64 Experience { get; set; }
		public Int64 ExpNextLevelFloor { get; set; }
		public UInt32 CreationDate { get; set; }
		public UInt16 NbTotalMembers { get; set; }
		public UInt16 NbConnectedMembers { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(AbandonnedPaddock);
			writer.WriteByte(Level);
			writer.WriteVarLong(ExpLevelFloor);
			writer.WriteVarLong(Experience);
			writer.WriteVarLong(ExpNextLevelFloor);
			writer.WriteInt((Int32)CreationDate);
			writer.WriteVarShort((Int16)NbTotalMembers);
			writer.WriteVarShort((Int16)NbConnectedMembers);
		}
		public void Deserialize(IDataReader reader)
		{
			AbandonnedPaddock = reader.ReadBoolean();
			Level = reader.ReadByte();
			ExpLevelFloor = reader.ReadVarLong();
			Experience = reader.ReadVarLong();
			ExpNextLevelFloor = reader.ReadVarLong();
			CreationDate = (UInt32)reader.ReadInt();
			NbTotalMembers = (UInt16)reader.ReadVarShort();
			NbConnectedMembers = (UInt16)reader.ReadVarShort();
		}
	}
}
