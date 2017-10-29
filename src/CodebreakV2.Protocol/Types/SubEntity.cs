using System;
namespace CodebreakV2.Protocol.Types
{
	public class SubEntity
	{
		public Byte BindingPointCategory { get; set; }
		public Byte BindingPointIndex { get; set; }
		public EntityLook SubEntityLook { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(BindingPointCategory);
			writer.WriteByte(BindingPointIndex);
			SubEntityLook.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			BindingPointCategory = reader.ReadByte();
			BindingPointIndex = reader.ReadByte();
			SubEntityLook = new EntityLook();
			SubEntityLook.Deserialize(reader);
		}
	}
}
