using System;
namespace CodebreakV2.Protocol.Types
{
	public class UpdateMountBoost
	{
		public Byte Type { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(Type);
		}
		public void Deserialize(IDataReader reader)
		{
			Type = reader.ReadByte();
		}
	}
}
