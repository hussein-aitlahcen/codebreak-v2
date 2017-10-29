using System;
namespace CodebreakV2.Protocol.Types
{
	public class DareReward
	{
		public Byte Type { get; set; }
		public UInt16 MonsterId { get; set; }
		public Int64 Kamas { get; set; }
		public Double DareId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(Type);
			writer.WriteVarShort((Int16)MonsterId);
			writer.WriteVarLong(Kamas);
			writer.WriteDouble(DareId);
		}
		public void Deserialize(IDataReader reader)
		{
			Type = reader.ReadByte();
			MonsterId = (UInt16)reader.ReadVarShort();
			Kamas = reader.ReadVarLong();
			DareId = reader.ReadDouble();
		}
	}
}
