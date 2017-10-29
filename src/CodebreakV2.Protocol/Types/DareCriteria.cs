using System;
namespace CodebreakV2.Protocol.Types
{
	public class DareCriteria
	{
		public Byte Type { get; set; }
		public Int32[] Params { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(Type);
			for (var i = 0; i < Params.Length; i++)
			{
				writer.WriteInt(Params[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Type = reader.ReadByte();
			Params = new Int32[reader.ReadShort()];
			for (var i = 0; i < Params.Length; i++)
			{
				Params[i] = reader.ReadInt();
			}
		}
	}
}
