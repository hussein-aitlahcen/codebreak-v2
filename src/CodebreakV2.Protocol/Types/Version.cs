using System;
namespace CodebreakV2.Protocol.Types
{
	public class Version
	{
		public Byte Major { get; set; }
		public Byte Minor { get; set; }
		public Byte Release { get; set; }
		public UInt32 Revision { get; set; }
		public Byte Patch { get; set; }
		public Byte BuildType { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(Major);
			writer.WriteByte(Minor);
			writer.WriteByte(Release);
			writer.WriteInt((Int32)Revision);
			writer.WriteByte(Patch);
			writer.WriteByte(BuildType);
		}
		public void Deserialize(IDataReader reader)
		{
			Major = reader.ReadByte();
			Minor = reader.ReadByte();
			Release = reader.ReadByte();
			Revision = (UInt32)reader.ReadInt();
			Patch = reader.ReadByte();
			BuildType = reader.ReadByte();
		}
	}
}
