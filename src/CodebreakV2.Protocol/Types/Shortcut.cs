using System;
namespace CodebreakV2.Protocol.Types
{
	public class Shortcut
	{
		public Byte Slot { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(Slot);
		}
		public void Deserialize(IDataReader reader)
		{
			Slot = reader.ReadByte();
		}
	}
}
