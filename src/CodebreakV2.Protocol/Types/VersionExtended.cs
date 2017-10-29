using System;
namespace CodebreakV2.Protocol.Types
{
	public class VersionExtended : Version
	{
		public Byte Install { get; set; }
		public Byte Technology { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(Install);
			writer.WriteByte(Technology);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Install = reader.ReadByte();
			Technology = reader.ReadByte();
		}
	}
}
