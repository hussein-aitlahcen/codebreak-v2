using System;
namespace CodebreakV2.Protocol.Types
{
	public class IndexedEntityLook
	{
		public EntityLook Look { get; set; }
		public Byte Index { get; set; }
		public void Serialize(IDataWriter writer)
		{
			Look.Serialize(writer);
			writer.WriteByte(Index);
		}
		public void Deserialize(IDataReader reader)
		{
			Look = new EntityLook();
			Look.Deserialize(reader);
			Index = reader.ReadByte();
		}
	}
}
