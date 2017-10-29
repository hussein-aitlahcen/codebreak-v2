using System;
namespace CodebreakV2.Protocol.Types
{
	public class EntityMovementInformations
	{
		public Int32 Id { get; set; }
		public SByte[] Steps { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt(Id);
			for (var i = 0; i < Steps.Length; i++)
			{
				writer.WriteByte((Byte)Steps[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Id = reader.ReadInt();
			Steps = new SByte[reader.ReadShort()];
			for (var i = 0; i < Steps.Length; i++)
			{
				Steps[i] = (SByte)reader.ReadByte();
			}
		}
	}
}
