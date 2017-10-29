using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class TaxCollectorStateUpdateMessage
	{
		public Double UniqueId { get; set; }
		public SByte State { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(UniqueId);
			writer.WriteByte((Byte)State);
		}
		public void Deserialize(IDataReader reader)
		{
			UniqueId = reader.ReadDouble();
			State = (SByte)reader.ReadByte();
		}
	}
}
