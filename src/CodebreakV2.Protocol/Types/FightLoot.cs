using System;
namespace CodebreakV2.Protocol.Types
{
	public class FightLoot
	{
		public UInt16[] Objects { get; set; }
		public Int64 Kamas { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Objects.Length; i++)
			{
				writer.WriteVarShort((Int16)Objects[i]);
			}
			writer.WriteVarLong(Kamas);
		}
		public void Deserialize(IDataReader reader)
		{
			Objects = new UInt16[reader.ReadShort()];
			for (var i = 0; i < Objects.Length; i++)
			{
				Objects[i] = (UInt16)reader.ReadVarShort();
			}
			Kamas = reader.ReadVarLong();
		}
	}
}
