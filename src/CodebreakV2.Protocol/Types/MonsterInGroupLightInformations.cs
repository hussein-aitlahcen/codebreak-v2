using System;
namespace CodebreakV2.Protocol.Types
{
	public class MonsterInGroupLightInformations
	{
		public Int32 CreatureGenericId { get; set; }
		public Byte Grade { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt(CreatureGenericId);
			writer.WriteByte(Grade);
		}
		public void Deserialize(IDataReader reader)
		{
			CreatureGenericId = reader.ReadInt();
			Grade = reader.ReadByte();
		}
	}
}
