using System;
namespace CodebreakV2.Protocol.Types
{
	public class ProtectedEntityWaitingForHelpInfo
	{
		public Int32 TimeLeftBeforeFight { get; set; }
		public Int32 WaitTimeForPlacement { get; set; }
		public Byte NbPositionForDefensors { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt(TimeLeftBeforeFight);
			writer.WriteInt(WaitTimeForPlacement);
			writer.WriteByte(NbPositionForDefensors);
		}
		public void Deserialize(IDataReader reader)
		{
			TimeLeftBeforeFight = reader.ReadInt();
			WaitTimeForPlacement = reader.ReadInt();
			NbPositionForDefensors = reader.ReadByte();
		}
	}
}
