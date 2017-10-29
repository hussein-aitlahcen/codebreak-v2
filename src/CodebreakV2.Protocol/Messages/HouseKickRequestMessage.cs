using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class HouseKickRequestMessage
	{
		public Int64 Id { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(Id);
		}
		public void Deserialize(IDataReader reader)
		{
			Id = reader.ReadVarLong();
		}
	}
}
