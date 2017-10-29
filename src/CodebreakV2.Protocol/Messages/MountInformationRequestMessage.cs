using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class MountInformationRequestMessage
	{
		public Double Id { get; set; }
		public Double Time { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(Id);
			writer.WriteDouble(Time);
		}
		public void Deserialize(IDataReader reader)
		{
			Id = reader.ReadDouble();
			Time = reader.ReadDouble();
		}
	}
}
