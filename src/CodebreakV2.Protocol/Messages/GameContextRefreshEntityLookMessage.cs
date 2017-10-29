using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameContextRefreshEntityLookMessage
	{
		public Double Id { get; set; }
		public EntityLook Look { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(Id);
			Look.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			Id = reader.ReadDouble();
			Look = new EntityLook();
			Look.Deserialize(reader);
		}
	}
}
